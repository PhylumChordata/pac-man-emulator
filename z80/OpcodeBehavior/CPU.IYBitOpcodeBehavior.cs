using System;

namespace JustinCredible.ZilogZ80
{
    public partial class CPU
    {
        private void ExecuteIYBitOpcode(Opcode opcode, out bool incrementProgramCounter, out bool useAlternateCycleCount)
        {
            incrementProgramCounter = true;
            useAlternateCycleCount = false;

            switch (opcode.Code)
            {
                #region Rotate

                    #region RLC (IY+n), r - Rotate left

                        case OpcodeBytes.RLC_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteRotate(value, left: true);
                            break;
                        }
                        case OpcodeBytes.RLC_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteRotate(value, left: true);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.RLC_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteRotate(value, left: true);
                            break;
                        }

                    #endregion

                    #region RRC (IY+n), r - Rotate right

                        case OpcodeBytes.RRC_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteRotate(value, left: false);
                            break;
                        }
                        case OpcodeBytes.RRC_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteRotate(value, left: false);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.RRC_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteRotate(value, left: false);
                            break;
                        }

                    #endregion

                    #region RL (IY+n), r - Rotate left through carry

                        case OpcodeBytes.RL_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RL_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.RL_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteRotate(value, left: true, rotateThroughCarry: true);
                            break;
                        }

                    #endregion

                    #region RR (IY+n), r - Rotate right through carry

                        case OpcodeBytes.RR_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }
                        case OpcodeBytes.RR_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.RR_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteRotate(value, left: false, rotateThroughCarry: true);
                            break;
                        }

                    #endregion

                #endregion

                #region Shift

                    #region SLA (IY+n), r - Shift left (arithmetic)
                        case OpcodeBytes.SLA_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLA_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteShiftArithmetic(value: value, left: true);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.SLA_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteShiftArithmetic(value: value, left: true);
                            break;
                        }
                    #endregion

                    #region SRA (IY+n), r - Shift right (arithmetic)
                        case OpcodeBytes.SRA_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRA_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteShiftArithmetic(value: value, left: false);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.SRA_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteShiftArithmetic(value: value, left: false);
                            break;
                        }
                    #endregion

                    // Despite the SLL mnemonic, it's not really a "shift left logical" operation.
                    // See: https://spectrumcomputing.co.uk/forums/viewtopic.php?p=9956&sid=f2072dd8da32b1a27a449433d387ebe6#p9956
                    #region SLL (IY+n), r - Shift left ?? (undocumented)
                        case OpcodeBytes.SLL_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                        case OpcodeBytes.SLL_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteShiftLogical(value: value, left: true);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.SLL_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteShiftLogical(value: value, left: true);
                            break;
                        }
                    #endregion

                    #region SRL (IY+n), r - Shift right logical
                        case OpcodeBytes.SRL_IY_B:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.B = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_C:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.C = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_D:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.D = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_E:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.E = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_H:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.H = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_L:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.L = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                        case OpcodeBytes.SRL_IY:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteShiftLogical(value: value, left: false);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }
                        case OpcodeBytes.SRL_IY_A:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            Registers.A = ExecuteShiftLogical(value: value, left: false);
                            break;
                        }
                    #endregion

                #endregion

                #region Test Bit

                    case OpcodeBytes.BIT_0_IY_2:
                    case OpcodeBytes.BIT_0_IY_3:
                    case OpcodeBytes.BIT_0_IY_4:
                    case OpcodeBytes.BIT_0_IY_5:
                    case OpcodeBytes.BIT_0_IY_6:
                    case OpcodeBytes.BIT_0_IY_7:
                    case OpcodeBytes.BIT_0_IY:
                    case OpcodeBytes.BIT_0_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(0, value);
                            break;
                        }

                    case OpcodeBytes.BIT_1_IY_2:
                    case OpcodeBytes.BIT_1_IY_3:
                    case OpcodeBytes.BIT_1_IY_4:
                    case OpcodeBytes.BIT_1_IY_5:
                    case OpcodeBytes.BIT_1_IY_6:
                    case OpcodeBytes.BIT_1_IY_7:
                    case OpcodeBytes.BIT_1_IY:
                    case OpcodeBytes.BIT_1_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(1, value);
                            break;
                        }

                    case OpcodeBytes.BIT_2_IY_2:
                    case OpcodeBytes.BIT_2_IY_3:
                    case OpcodeBytes.BIT_2_IY_4:
                    case OpcodeBytes.BIT_2_IY_5:
                    case OpcodeBytes.BIT_2_IY_6:
                    case OpcodeBytes.BIT_2_IY_7:
                    case OpcodeBytes.BIT_2_IY:
                    case OpcodeBytes.BIT_2_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(2, value);
                            break;
                        }

                    case OpcodeBytes.BIT_3_IY_2:
                    case OpcodeBytes.BIT_3_IY_3:
                    case OpcodeBytes.BIT_3_IY_4:
                    case OpcodeBytes.BIT_3_IY_5:
                    case OpcodeBytes.BIT_3_IY_6:
                    case OpcodeBytes.BIT_3_IY_7:
                    case OpcodeBytes.BIT_3_IY:
                    case OpcodeBytes.BIT_3_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(3, value);
                            break;
                        }

                    case OpcodeBytes.BIT_4_IY_2:
                    case OpcodeBytes.BIT_4_IY_3:
                    case OpcodeBytes.BIT_4_IY_4:
                    case OpcodeBytes.BIT_4_IY_5:
                    case OpcodeBytes.BIT_4_IY_6:
                    case OpcodeBytes.BIT_4_IY_7:
                    case OpcodeBytes.BIT_4_IY:
                    case OpcodeBytes.BIT_4_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(4, value);
                            break;
                        }

                    case OpcodeBytes.BIT_5_IY_2:
                    case OpcodeBytes.BIT_5_IY_3:
                    case OpcodeBytes.BIT_5_IY_4:
                    case OpcodeBytes.BIT_5_IY_5:
                    case OpcodeBytes.BIT_5_IY_6:
                    case OpcodeBytes.BIT_5_IY_7:
                    case OpcodeBytes.BIT_5_IY:
                    case OpcodeBytes.BIT_5_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(5, value);
                            break;
                        }

                    case OpcodeBytes.BIT_6_IY_2:
                    case OpcodeBytes.BIT_6_IY_3:
                    case OpcodeBytes.BIT_6_IY_4:
                    case OpcodeBytes.BIT_6_IY_5:
                    case OpcodeBytes.BIT_6_IY_6:
                    case OpcodeBytes.BIT_6_IY_7:
                    case OpcodeBytes.BIT_6_IY:
                    case OpcodeBytes.BIT_6_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(6, value);
                            break;
                        }

                    case OpcodeBytes.BIT_7_IY_2:
                    case OpcodeBytes.BIT_7_IY_3:
                    case OpcodeBytes.BIT_7_IY_4:
                    case OpcodeBytes.BIT_7_IY_5:
                    case OpcodeBytes.BIT_7_IY_6:
                    case OpcodeBytes.BIT_7_IY_7:
                    case OpcodeBytes.BIT_7_IY:
                    case OpcodeBytes.BIT_7_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            ExecuteTestBit(7, value);
                            break;
                        }

                #endregion

                #region Reset Bit

                    case OpcodeBytes.RES_0_IY_2:
                    case OpcodeBytes.RES_0_IY_3:
                    case OpcodeBytes.RES_0_IY_4:
                    case OpcodeBytes.RES_0_IY_5:
                    case OpcodeBytes.RES_0_IY_6:
                    case OpcodeBytes.RES_0_IY_7:
                    case OpcodeBytes.RES_0_IY:
                    case OpcodeBytes.RES_0_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(0, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_1_IY_2:
                    case OpcodeBytes.RES_1_IY_3:
                    case OpcodeBytes.RES_1_IY_4:
                    case OpcodeBytes.RES_1_IY_5:
                    case OpcodeBytes.RES_1_IY_6:
                    case OpcodeBytes.RES_1_IY_7:
                    case OpcodeBytes.RES_1_IY:
                    case OpcodeBytes.RES_1_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(1, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_2_IY_2:
                    case OpcodeBytes.RES_2_IY_3:
                    case OpcodeBytes.RES_2_IY_4:
                    case OpcodeBytes.RES_2_IY_5:
                    case OpcodeBytes.RES_2_IY_6:
                    case OpcodeBytes.RES_2_IY_7:
                    case OpcodeBytes.RES_2_IY:
                    case OpcodeBytes.RES_2_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(2, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_3_IY_2:
                    case OpcodeBytes.RES_3_IY_3:
                    case OpcodeBytes.RES_3_IY_4:
                    case OpcodeBytes.RES_3_IY_5:
                    case OpcodeBytes.RES_3_IY_6:
                    case OpcodeBytes.RES_3_IY_7:
                    case OpcodeBytes.RES_3_IY:
                    case OpcodeBytes.RES_3_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(3, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_4_IY_2:
                    case OpcodeBytes.RES_4_IY_3:
                    case OpcodeBytes.RES_4_IY_4:
                    case OpcodeBytes.RES_4_IY_5:
                    case OpcodeBytes.RES_4_IY_6:
                    case OpcodeBytes.RES_4_IY_7:
                    case OpcodeBytes.RES_4_IY:
                    case OpcodeBytes.RES_4_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(4, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_5_IY_2:
                    case OpcodeBytes.RES_5_IY_3:
                    case OpcodeBytes.RES_5_IY_4:
                    case OpcodeBytes.RES_5_IY_5:
                    case OpcodeBytes.RES_5_IY_6:
                    case OpcodeBytes.RES_5_IY_7:
                    case OpcodeBytes.RES_5_IY:
                    case OpcodeBytes.RES_5_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(5, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_6_IY_2:
                    case OpcodeBytes.RES_6_IY_3:
                    case OpcodeBytes.RES_6_IY_4:
                    case OpcodeBytes.RES_6_IY_5:
                    case OpcodeBytes.RES_6_IY_6:
                    case OpcodeBytes.RES_6_IY_7:
                    case OpcodeBytes.RES_6_IY:
                    case OpcodeBytes.RES_6_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(6, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.RES_7_IY_2:
                    case OpcodeBytes.RES_7_IY_3:
                    case OpcodeBytes.RES_7_IY_4:
                    case OpcodeBytes.RES_7_IY_5:
                    case OpcodeBytes.RES_7_IY_6:
                    case OpcodeBytes.RES_7_IY_7:
                    case OpcodeBytes.RES_7_IY:
                    case OpcodeBytes.RES_7_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteResetBit(7, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                #endregion

                #region Set Bit

                    case OpcodeBytes.SET_0_IY_2:
                    case OpcodeBytes.SET_0_IY_3:
                    case OpcodeBytes.SET_0_IY_4:
                    case OpcodeBytes.SET_0_IY_5:
                    case OpcodeBytes.SET_0_IY_6:
                    case OpcodeBytes.SET_0_IY_7:
                    case OpcodeBytes.SET_0_IY:
                    case OpcodeBytes.SET_0_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(0, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_1_IY_2:
                    case OpcodeBytes.SET_1_IY_3:
                    case OpcodeBytes.SET_1_IY_4:
                    case OpcodeBytes.SET_1_IY_5:
                    case OpcodeBytes.SET_1_IY_6:
                    case OpcodeBytes.SET_1_IY_7:
                    case OpcodeBytes.SET_1_IY:
                    case OpcodeBytes.SET_1_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(1, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_2_IY_2:
                    case OpcodeBytes.SET_2_IY_3:
                    case OpcodeBytes.SET_2_IY_4:
                    case OpcodeBytes.SET_2_IY_5:
                    case OpcodeBytes.SET_2_IY_6:
                    case OpcodeBytes.SET_2_IY_7:
                    case OpcodeBytes.SET_2_IY:
                    case OpcodeBytes.SET_2_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(2, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_3_IY_2:
                    case OpcodeBytes.SET_3_IY_3:
                    case OpcodeBytes.SET_3_IY_4:
                    case OpcodeBytes.SET_3_IY_5:
                    case OpcodeBytes.SET_3_IY_6:
                    case OpcodeBytes.SET_3_IY_7:
                    case OpcodeBytes.SET_3_IY:
                    case OpcodeBytes.SET_3_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(3, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_4_IY_2:
                    case OpcodeBytes.SET_4_IY_3:
                    case OpcodeBytes.SET_4_IY_4:
                    case OpcodeBytes.SET_4_IY_5:
                    case OpcodeBytes.SET_4_IY_6:
                    case OpcodeBytes.SET_4_IY_7:
                    case OpcodeBytes.SET_4_IY:
                    case OpcodeBytes.SET_4_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(4, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_5_IY_2:
                    case OpcodeBytes.SET_5_IY_3:
                    case OpcodeBytes.SET_5_IY_4:
                    case OpcodeBytes.SET_5_IY_5:
                    case OpcodeBytes.SET_5_IY_6:
                    case OpcodeBytes.SET_5_IY_7:
                    case OpcodeBytes.SET_5_IY:
                    case OpcodeBytes.SET_5_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(5, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_6_IY_2:
                    case OpcodeBytes.SET_6_IY_3:
                    case OpcodeBytes.SET_6_IY_4:
                    case OpcodeBytes.SET_6_IY_5:
                    case OpcodeBytes.SET_6_IY_6:
                    case OpcodeBytes.SET_6_IY_7:
                    case OpcodeBytes.SET_6_IY:
                    case OpcodeBytes.SET_6_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(6, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                    case OpcodeBytes.SET_7_IY_2:
                    case OpcodeBytes.SET_7_IY_3:
                    case OpcodeBytes.SET_7_IY_4:
                    case OpcodeBytes.SET_7_IY_5:
                    case OpcodeBytes.SET_7_IY_6:
                    case OpcodeBytes.SET_7_IY_7:
                    case OpcodeBytes.SET_7_IY:
                    case OpcodeBytes.SET_7_IY_8:
                        {
                            var offset = (sbyte)Memory[Registers.PC + 2];
                            var value = ReadMemory(Registers.IY + offset);
                            value = ExecuteSetBit(7, value);
                            WriteMemory(Registers.IY + offset, value);
                            break;
                        }

                #endregion

                default:
                    throw new NotImplementedException(String.Format("Attempted to execute unknown opcode 0x{0:X2} at memory address 0x{1:X4}", opcode, Registers.PC));
            }
        }
    }
}
