using System;

namespace JustinCredible.ZilogZ80
{
    // TODO: Update with Z80 mnemonics.
    // TODO: Add z80 specific instructions.

    // A list of all the "standard" opcode bytes; can be used to lookup the opcode definition.
    public partial class OpcodeBytes
    {
        /** Halt CPU */
        public const byte HALT = 0x76;

        #region NOP - No operation
            public const byte NOP = 0x00;
            public const byte NOP2 = 0x10; // TODO
            public const byte NOP3 = 0x20; // TODO
            public const byte NOP4 = 0x30; // TODO
            public const byte NOP5 = 0x08; // TODO
            public const byte NOP6 = 0x18; // TODO
            public const byte NOP7 = 0x28; // TODO
            public const byte NOP8 = 0x38; // TODO
        #endregion

        #region Carry bit instructions

            /** Set Carry */
            public const byte STC = 0x37;

            /** Complement Carry */
            public const byte CMC = 0x3f;

        #endregion

        #region Single register instructions

            #region INC r - Increment Register or Memory
                public const byte INC_B = 0x04;
                public const byte INC_C = 0x0c;
                public const byte INC_D = 0x14;
                public const byte INC_E = 0x1c;
                public const byte INC_H = 0x24;
                public const byte INC_L = 0x2c;
                public const byte INC_MHL = 0x34;
                public const byte INC_A = 0x3c;
            #endregion

            #region DEC r - Decrement Register or Memory
                public const byte DEC_B = 0x05;
                public const byte DEC_C = 0x0d;
                public const byte DEC_D = 0x15;
                public const byte DEC_E = 0x1d;
                public const byte DEC_H = 0x25;
                public const byte DEC_L = 0x2d;
                public const byte DEC_MHL = 0x35;
                public const byte DEC_A = 0x3d;
            #endregion

            /** Compliment Accumulator */
            public const byte CMA = 0x2f;

            /** Decimal Adjust Accumulator */
            public const byte DAA = 0x27;

        #endregion

        #region Data transfer instructions

            #region LD (rr), A - Store accumulator
                public const byte LD_MBC_A = 0x02;
                public const byte LD_MDE_A = 0x12;
            #endregion

            #region LD A, (rr) - Load accumulator
                public const byte LD_A_MBC = 0x0a;
                public const byte LD_A_MDE = 0x1a;
            #endregion

            #region LD - Load (copy) data
                public const byte LD_B_B = 0x40;
                public const byte LD_B_C = 0x41;
                public const byte LD_B_D = 0x42;
                public const byte LD_B_E = 0x43;
                public const byte LD_B_H = 0x44;
                public const byte LD_B_L = 0x45;
                public const byte LD_B_MHL = 0x46;
                public const byte LD_B_A = 0x47;
                public const byte LD_C_B = 0x48;
                public const byte LD_C_C = 0x49;
                public const byte LD_C_D = 0x4a;
                public const byte LD_C_E = 0x4b;
                public const byte LD_C_H = 0x4c;
                public const byte LD_C_L = 0x4d;
                public const byte LD_C_MHL = 0x4e;
                public const byte LD_C_A = 0x4f;
                public const byte LD_D_B = 0x50;
                public const byte LD_D_C = 0x51;
                public const byte LD_D_D = 0x52;
                public const byte LD_D_E = 0x53;
                public const byte LD_D_H = 0x54;
                public const byte LD_D_L = 0x55;
                public const byte LD_D_MHL = 0x56;
                public const byte LD_D_A = 0x57;
                public const byte LD_E_B = 0x58;
                public const byte LD_E_C = 0x59;
                public const byte LD_E_D = 0x5a;
                public const byte LD_E_E = 0x5b;
                public const byte LD_E_H = 0x5c;
                public const byte LD_E_L = 0x5d;
                public const byte LD_E_MHL = 0x5e;
                public const byte LD_E_A = 0x5f;
                public const byte LD_H_B = 0x60;
                public const byte LD_H_C = 0x61;
                public const byte LD_H_D = 0x62;
                public const byte LD_H_E = 0x63;
                public const byte LD_H_H = 0x64;
                public const byte LD_H_L = 0x65;
                public const byte LD_H_MHL = 0x66;
                public const byte LD_H_A = 0x67;
                public const byte LD_L_B = 0x68;
                public const byte LD_L_C = 0x69;
                public const byte LD_L_D = 0x6a;
                public const byte LD_L_E = 0x6b;
                public const byte LD_L_H = 0x6c;
                public const byte LD_L_L = 0x6d;
                public const byte LD_L_MHL = 0x6e;
                public const byte LD_L_A = 0x6f;
                public const byte LD_MHL_B = 0x70;
                public const byte LD_MHL_C = 0x71;
                public const byte LD_MHL_D = 0x72;
                public const byte LD_MHL_E = 0x73;
                public const byte LD_MHL_H = 0x74;
                public const byte LD_MHL_L = 0x75;
                public const byte LD_MHL_A = 0x77;
                public const byte LD_A_B = 0x78;
                public const byte LD_A_C = 0x79;
                public const byte LD_A_D = 0x7a;
                public const byte LD_A_E = 0x7b;
                public const byte LD_A_H = 0x7c;
                public const byte LD_A_L = 0x7d;
                public const byte LD_A_MHL = 0x7e;
                public const byte LD_A_A = 0x7f;
            #endregion

        #endregion

        #region Register or memory to accumulator instructions

            #region ADD - Add register or memory to accumulator
                public const byte ADD_A_B = 0x80;
                public const byte ADD_A_C = 0x81;
                public const byte ADD_A_D = 0x82;
                public const byte ADD_A_E = 0x83;
                public const byte ADD_A_H = 0x84;
                public const byte ADD_A_L = 0x85;
                public const byte ADD_A_MHL = 0x86;
                public const byte ADD_A_A = 0x87;
            #endregion

            #region SUB - Subtract register or memory from accumulator
                public const byte SUB_B = 0x90;
                public const byte SUB_C = 0x91;
                public const byte SUB_D = 0x92;
                public const byte SUB_E = 0x93;
                public const byte SUB_H = 0x94;
                public const byte SUB_L = 0x95;
                public const byte SUB_MHL = 0x96;
                public const byte SUB_A = 0x97;
            #endregion

            #region AND - Logical AND register or memory with accumulator
                public const byte AND_B = 0xa0;
                public const byte AND_C = 0xa1;
                public const byte AND_D = 0xa2;
                public const byte AND_E = 0xa3;
                public const byte AND_H = 0xa4;
                public const byte AND_L = 0xa5;
                public const byte AND_MHL = 0xa6;
                public const byte AND_A = 0xa7;
            #endregion

            #region OR - Logical OR register or memory with accumulator
                public const byte OR_B = 0xb0;
                public const byte OR_C = 0xb1;
                public const byte OR_D = 0xb2;
                public const byte OR_E = 0xb3;
                public const byte OR_H = 0xb4;
                public const byte OR_L = 0xb5;
                public const byte OR_MHL = 0xb6;
                public const byte OR_A = 0xb7;
            #endregion

            #region ADC - Add register or memory to accumulator with carry
                public const byte ADC_A_B = 0x88;
                public const byte ADC_A_C = 0x89;
                public const byte ADC_A_D = 0x8a;
                public const byte ADC_A_E = 0x8b;
                public const byte ADC_A_H = 0x8c;
                public const byte ADC_A_L = 0x8d;
                public const byte ADC_A_MHL = 0x8e;
                public const byte ADC_A_A = 0x8f;
            #endregion

            #region SBC - Subtract register or memory from accumulator with borrow
                public const byte SBC_A_B = 0x98;
                public const byte SBC_A_C = 0x99;
                public const byte SBC_A_D = 0x9a;
                public const byte SBC_A_E = 0x9b;
                public const byte SBC_A_H = 0x9c;
                public const byte SBC_A_L = 0x9d;
                public const byte SBC_A_MHL = 0x9e;
                public const byte SBC_A_A = 0x9f;
            #endregion

            #region XOR - Logical XOR register or memory with accumulator
                public const byte XOR_B = 0xa8;
                public const byte XOR_C = 0xa9;
                public const byte XOR_D = 0xaa;
                public const byte XOR_E = 0xab;
                public const byte XOR_H = 0xac;
                public const byte XOR_L = 0xad;
                public const byte XOR_MHL = 0xae;
                public const byte XOR_A = 0xaf;
            #endregion

            #region CP - Compare register or memory with accumulator
                public const byte CP_B = 0xb8;
                public const byte CP_C = 0xb9;
                public const byte CP_D = 0xba;
                public const byte CP_E = 0xbb;
                public const byte CP_H = 0xbc;
                public const byte CP_L = 0xbd;
                public const byte CP_MHL = 0xbe;
                public const byte CP_A = 0xbf;
            #endregion

        #endregion

        #region Rotate accumulator instructions

            /** Rotate accumulator left */
            public const byte RLC = 0x07;

            /** Rotate accumulator right */
            public const byte RRC = 0x0f;

            /** Rotate accumulator left through carry */
            public const byte RAL = 0x17;

            /** Rotate accumulator right through carry */
            public const byte RAR = 0x1f;

        #endregion

        #region Register pair instructions

            #region INC rr - Increment register pair
                public const byte INC_BC = 0x03;
                public const byte INC_DE = 0x13;
                public const byte INC_HL = 0x23;
                public const byte INC_SP = 0x33;
            #endregion

            #region DEC rr - Decrement register pair
                public const byte DEC_BC = 0x0b;
                public const byte DEC_DE = 0x1b;
                public const byte DEC_HL = 0x2b;
                public const byte DEC_SP = 0x3b;
            #endregion

            #region PUSH - Push data onto the stack
                public const byte PUSH_BC = 0xc5;
                public const byte PUSH_DE = 0xd5;
                public const byte PUSH_HL = 0xe5;
                public const byte PUSH_AF = 0xf5;
            #endregion

            #region POP - Pop data off of the stack
                public const byte POP_BC = 0xc1;
                public const byte POP_DE = 0xd1;
                public const byte POP_HL = 0xe1;
                public const byte POP_AF = 0xf1;
            #endregion

            #region DAD - Double (16-bit) add
                public const byte DAD_B = 0x09;
                public const byte DAD_D = 0x19;
                public const byte DAD_H = 0x29;
                public const byte DAD_SP = 0x39;
            #endregion

            /** Load SP from H and L */
            public const byte SPHL = 0xf9;

            /** Exchange stack */
            public const byte XTHL = 0xe3;

            /** Exchange registers */
            public const byte XCHG = 0xeb;

        #endregion

        #region Immediate instructions

            #region LD r, n - Load immediate data
                public const byte LD_B_N = 0x06;
                public const byte LD_C_N = 0x0e;
                public const byte LD_D_N = 0x16;
                public const byte LD_E_N = 0x1e;
                public const byte LD_H_N = 0x26;
                public const byte LD_L_N = 0x2e;
                public const byte LD_MHL_N = 0x36;
                public const byte LD_A_N = 0x3e;
            #endregion

            #region LD rr, nn - Load register pair immediate
                public const byte LD_BC_NN = 0x01;
                public const byte LD_DE_NN = 0x11;
                public const byte LD_HL_NN = 0x21;
                public const byte LD_SP_NN = 0x31;
            #endregion

            /** Add immediate to accumulator */
            public const byte ADD_A_N = 0xc6;

            /** Add immediate to accumulator with carry */
            public const byte ADC_A_N = 0xce;

            /** Subtract immediate from accumulator */
            public const byte SUB_N = 0xd6;

            /** Subtract immediate from accumulator with borrow */
            public const byte SBC_A_N = 0xde;

            /** Logical AND immediate with accumulator */
            public const byte AND_N = 0xe6;

            /** XOR immediate with accumulator */
            public const byte XOR_N = 0xee;

            /** Logical OR immediate with accumulator */
            public const byte OR_N = 0xf6;

            /** Compare immediate with accumulator */
            public const byte CP_N = 0xfe;

        #endregion

        #region Direct addressing instructions

            /** Store accumulator direct */
            public const byte LD_MNN_A = 0x32;

            /** Load accumulator direct */
            public const byte LD_A_MNN = 0x3a;

            /** Store H and L direct */
            public const byte LD_MNN_HL = 0x22;

            /** Load H and L direct */
            public const byte LD_HL_MNN = 0x2a;

        #endregion

        #region Jump instructions

            /** Load program counter */
            public const byte JP_HL = 0xe9;

            /** Jump */
            public const byte JP = 0xc3;

            /** Jump if parity odd */
            public const byte JP_PO = 0xe2;

            /** Jump if parity even */
            public const byte JP_PE = 0xea;

            /** Jump if plus/positive */
            public const byte JP_P = 0xf2;

            /** Jump if zero */
            public const byte JP_Z = 0xca;

            /** Jump if not zero */
            public const byte JP_NZ = 0xc2;

            /** Jump if not carry */
            public const byte JP_NC = 0xd2;

            /** Jump if carry */
            public const byte JP_C = 0xda;

            /** Jump if minus/negative */
            public const byte JP_M = 0xfa;

        #endregion

        #region Call subroutine instructions

            public const byte CALL = 0xcd;

            /** Call if minus/negative */
            public const byte CM = 0xfc;

            /** Call if party even */
            public const byte CPE = 0xec;

            /** Call if carry */
            public const byte CC = 0xdc;

            /** Call if zero */
            public const byte CZ = 0xcc;

            /** Call if plus/positive */
            public const byte CP = 0xf4;

            /** Call if party odd */
            public const byte CPO = 0xe4;

            /** Call if no carry */
            public const byte CNC = 0xd4;

            /** Call if not zero */
            public const byte CNZ = 0xc4;

        #endregion

        #region Return from subroutine instructions

            /** Return from subroutine */
            public const byte RET = 0xc9;

            /** Return from subroutine (duplicate) */
            public const byte RET2 = 0xd9; // TODO

            /** Return if not zero */
            public const byte RET_NZ = 0xc0;

            /** Return if zero */
            public const byte RET_Z = 0xc8;

            /** Return if no carry */
            public const byte RET_NC = 0xd0;

            /** Return if carry */
            public const byte RET_C = 0xd8;

            /** Return if parity odd */
            public const byte RET_PO = 0xe0;

            /** Return if parity even */
            public const byte RET_PE = 0xe8;

            /** Return if plus/positive */
            public const byte RET_P = 0xf0;

            /** Return if minus/negative */
            public const byte RET_M = 0xf8;

        #endregion

        #region Restart (interrupt handlers) instructions

            /** CALL $0 */
            public const byte RST_0 = 0xc7;

            /** CALL $8 */
            public const byte RST_1 = 0xcf;

            /** CALL $10 */
            public const byte RST_2 = 0xd7;

            /** CALL $18 */
            public const byte RST_3 = 0xdf;

            /** CALL $20 */
            public const byte RST_4 = 0xe7;

            /** CALL $28 */
            public const byte RST_5 = 0xef;

            /** CALL $30 */
            public const byte RST_6 = 0xf7;

            /** CALL $38 */
            public const byte RST_7 = 0xff;

        #endregion

        #region Interrupt flip-flop instructions

            /** Enable interrupts */
            public const byte EI = 0xfb;

            /** Disable interrupts */
            public const byte DI = 0xf3;

        #endregion

        #region Input/Output Instructions

            /** Output accumulator to given device number */
            public const byte OUT = 0xd3;

            /** Retrieve input from given device number and populate accumulator */
            public const byte IN = 0xdb;

        #endregion
    }
}
