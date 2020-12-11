/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Ldobj,
        Stelem_Ref,
        Ldflda,
        Ldind_Ref,
        Add,
        Refanyval,
        Ldtoken,
        Xor,
        Stloc,
        Conv_Ovf_I4_Un,
        Ble,
        Refanytype,
        Conv_Ovf_I,
        Break,
        Stelem_I1,
        Conv_Ovf_U1,
        Sub_Ovf,
        Conv_I,
        Readonly,
        Initobj,
        Conv_Ovf_I1_Un,
        Blt_Un,
        Clt,
        Blt,
        Dup,
        Stelem_Any,
        Neg,
        Initblk,
        Ldloc,
        Unbox,
        Conv_Ovf_U2,
        Mul_Ovf,
        Ldstr,
        Ldind_R8,
        Starg,
        Shr,
        Conv_Ovf_U,
        Clt_Un,
        CallExtern,
        Or,
        Mkrefany,
        Pop,
        Callvirtvirt,
        Bgt_Un,
        And,
        Conv_R_Un,
        Add_Ovf,
        Shr_Un,
        Conv_U8,
        Shl,
        Conv_R4,
        Ldind_U1,
        Leave,
        Unbox_Any,
        Conv_I2,
        Rethrow,
        Sub,
        Conv_Ovf_I2_Un,
        Tail,
        Newanon,
        Callvirt,
        Mul_Ovf_Un,
        Brtrue,
        Newobj,
        Box,
        No,
        Sizeof,
        Cgt,
        Conv_U,
        Rem_Un,
        Stind_I4,
        Add_Ovf_Un,
        Volatile,
        Conv_I4,
        Stind_I1,
        Ldelem_I1,
        Beq,
        Conv_Ovf_U8_Un,
        Ldelem_I,
        Rem,
        Sub_Ovf_Un,
        Ldelem_I2,
        Ldind_I1,
        Conv_Ovf_U_Un,
        Mul,
        Div,
        Bgt,
        Castclass,
        Ldloca,
        Ceq,
        Ldc_I8,
        Ret,
        Conv_I8,
        Stelem_I4,
        Localloc,
        Ldfld,
        Stelem_R4,
        Isinst,
        Constrained,
        Ble_Un,
        Ldelem_U2,
        Ldind_I2,
        Stelem_I,
        Ldind_I8,
        Conv_Ovf_I8_Un,
        Ldtype, // custom
        Endfilter,
        Ldind_U2,
        Conv_R8,
        Conv_Ovf_I8,
        Cpblk,
        Ldc_I4,
        Ldsfld,
        Ldlen,
        Stsfld,
        Cgt_Un,
        Endfinally,
        Stelem_R8,
        Ldftn,
        Conv_Ovf_U1_Un,
        Ldvirtftn2,
        Ldind_R4,
        Not,
        Conv_Ovf_U8,
        Bge_Un,
        Ldelem_Any,
        Ldelem_R8,
        Cpobj,
        Arglist,
        Ldind_I4,
        Stind_Ref,
        Bne_Un,
        Ldvirtftn,

        //Pseudo instruction
        StackSpace,
        Conv_U2,
        Ckfinite,
        Stelem_I2,
        Ldelem_R4,
        Brfalse,
        Stobj,
        Conv_I1,
        Conv_Ovf_I2,
        Ldind_I,
        Stfld,
        Call,
        Stind_R8,
        Stelem_I8,
        Conv_Ovf_I_Un,
        Stind_I8,
        Ldelem_U4,
        Switch,
        Conv_Ovf_U2_Un,
        Ldc_R8,
        Ldelem_I8,
        Stind_R4,
        Ldelem_Ref,
        Ldnull,
        Conv_Ovf_U4,
        Ldind_U4,
        Jmp,
        Ldc_R4,
        Conv_Ovf_I4,
        Stind_I2,
        Stind_I,
        Ldarg,
        Ldarga,
        Conv_U4,
        Ldelem_U1,
        Ldelema,
        Bge,
        Ldsflda,
        Ldelem_I4,
        Div_Un,
        //Calli,
        Conv_Ovf_U4_Un,
        Unaligned,
        Br,
        Newarr,
        Conv_U1,
        Throw,
        Conv_Ovf_I1,
        Nop,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 6484502548677692840;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}