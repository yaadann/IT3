using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Rabin
    {
        public const int BLOCK = 2;
        public const int COUNT_OF_CANDIDATES = 4;
        public const int BYTE_MAX_VALUE = 256;
        private int p;
        private int q;
        private int b;
        private long n;
        private byte[] bytes;
        private List<long> blocks;


        public static bool CorrectNum(int num)
        {
            return (num % 4) == 3;
        }

        public Rabin(int p, int q, int b, long n, byte[] bytes)
        {
            this.p = p;
            this.q = q;
            this.b = b;
            this.n = n;
            this.bytes = bytes;
        }

        public Rabin(int p, int q, int b, long n, List<long> blocks)
        {
            this.p = p;
            this.q = q;
            this.b = b;
            this.n = n;
            this.blocks = blocks;
        }

        public long[] GetEncoodedBytes()
        {
            long[] encodedbBlocks = new long[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                encodedbBlocks[i] = (bytes[i] % n) * ((bytes[i] + b) % n) % n;
            }
            return encodedbBlocks;
        }

        private long GetDiscriminant(long c)
        {
            return (Convert.ToInt32(Math.Pow(b, 2)) + 4*c) % n;
        }

        private long SelectCorrectCandidate(long[] roots)
        {
            long[] candidates = new long[COUNT_OF_CANDIDATES];
            for (int i = 0; i < roots.Length; i++)
            {
                if ((roots[i] - b) % 2 == 0)
                {
                    candidates[i] = ((-b + roots[i]) / 2) % n;
                }
                else
                {
                    candidates[i] = ((-b + n + roots[i]) / 2) % n;
                }
                if (candidates[i] < 0)
                    candidates[i] += n;

            }
            long correct = 0;
            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] < BYTE_MAX_VALUE)
                    return candidates[i];
            }
            return correct;
        }

        public byte[] GetDecodedBytes()
        {
            byte[] bytes = new byte[blocks.Count];
            int j = 0;
            for (int i = 0; i < blocks.Count; i++)
            {
                long D = GetDiscriminant(blocks[i]);
                if (D < 0) D += n;
                int mp = MathOperations.ModPow((int)D, (p + 1) / 4, p);
                int mq = MathOperations.ModPow((int)D, (q + 1) / 4, q);
                MathOperations.ExtendedEuclid(p, q, out int yp, out int yq);
                long r1 = (yp * p * mq + yq * q * mp) % n;
                if (r1 < 0) r1 += n;
                long r2 = n - r1;
                long r3 = (yp * p * mq - yq * q * mp) % n;
                if (r3 < 0) r3 += n;
                long r4 = n - r3;
                    
                long correct = SelectCorrectCandidate(new long[] { r1, r2, r3, r4 });

                bytes[j] = ((byte)(correct & 0xFF));
                j++;
            }
            return bytes;
            
        }
    }
}
