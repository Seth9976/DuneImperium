using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000101 RID: 257
	public class CastInstruction : Instruction
	{
		// Token: 0x06000F8C RID: 3980 RVA: 0x00052838 File Offset: 0x00050A38
		// Note: this type is marked as 'beforefieldinit'.
		static CastInstruction()
		{
			Il2CppClassPointerStore<CastInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CastInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr);
			CastInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Boolean");
			CastInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Byte");
			CastInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Char");
			CastInstruction.NativeFieldInfoPtr_s_DateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_DateTime");
			CastInstruction.NativeFieldInfoPtr_s_Decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Decimal");
			CastInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Double");
			CastInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Int16");
			CastInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Int32");
			CastInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Int64");
			CastInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_SByte");
			CastInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_Single");
			CastInstruction.NativeFieldInfoPtr_s_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_String");
			CastInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_UInt16");
			CastInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_UInt32");
			CastInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "s_UInt64");
			CastInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, 100666204);
			CastInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, 100666205);
			CastInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, 100666206);
			CastInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, 100666207);
			CastInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, 100666208);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000529F8 File Offset: 0x00050BF8
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CastInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00052A40 File Offset: 0x00050C40
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CastInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00052A88 File Offset: 0x00050C88
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026578, XrefRangeEnd = 1026580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CastInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00052ACC File Offset: 0x00050CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026623, RefRangeEnd = 1026624, XrefRangeStart = 1026580, XrefRangeEnd = 1026623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00052B10 File Offset: 0x00050D10
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CastInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00006CE7 File Offset: 0x00004EE7
		public CastInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00052B4C File Offset: 0x00050D4C
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public unsafe static CastInstruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00052B74 File Offset: 0x00050D74
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00006D02 File Offset: 0x00004F02
		public unsafe static CastInstruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00052B9C File Offset: 0x00050D9C
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00006D14 File Offset: 0x00004F14
		public unsafe static CastInstruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00052BC4 File Offset: 0x00050DC4
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00006D26 File Offset: 0x00004F26
		public unsafe static CastInstruction s_DateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_DateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_DateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00052BEC File Offset: 0x00050DEC
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00006D38 File Offset: 0x00004F38
		public unsafe static CastInstruction s_Decimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Decimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Decimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00052C14 File Offset: 0x00050E14
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00006D4A File Offset: 0x00004F4A
		public unsafe static CastInstruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00052C3C File Offset: 0x00050E3C
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00006D5C File Offset: 0x00004F5C
		public unsafe static CastInstruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00052C64 File Offset: 0x00050E64
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00006D6E File Offset: 0x00004F6E
		public unsafe static CastInstruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00052C8C File Offset: 0x00050E8C
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00006D80 File Offset: 0x00004F80
		public unsafe static CastInstruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00052CB4 File Offset: 0x00050EB4
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00006D92 File Offset: 0x00004F92
		public unsafe static CastInstruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00052CDC File Offset: 0x00050EDC
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public unsafe static CastInstruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00052D04 File Offset: 0x00050F04
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00006DB6 File Offset: 0x00004FB6
		public unsafe static CastInstruction s_String
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_String, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_String, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00052D2C File Offset: 0x00050F2C
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00006DC8 File Offset: 0x00004FC8
		public unsafe static CastInstruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00052D54 File Offset: 0x00050F54
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00006DDA File Offset: 0x00004FDA
		public unsafe static CastInstruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00052D7C File Offset: 0x00050F7C
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00006DEC File Offset: 0x00004FEC
		public unsafe static CastInstruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CastInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CastInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_s_DateTime;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeFieldInfoPtr_s_Decimal;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_s_String;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000328 RID: 808
		public sealed class CastInstructionT<T> : CastInstruction
		{
			// Token: 0x06001B13 RID: 6931 RVA: 0x00080E18 File Offset: 0x0007F018
			// Note: this type is marked as 'beforefieldinit'.
			static CastInstructionT()
			{
				Il2CppClassPointerStore<CastInstruction.CastInstructionT<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "CastInstructionT`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastInstruction.CastInstructionT<T>>.NativeClassPtr);
				CastInstruction.CastInstructionT<T>.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionT<T>>.NativeClassPtr, 100666209);
				CastInstruction.CastInstructionT<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionT<T>>.NativeClassPtr, 100666210);
			}

			// Token: 0x06001B14 RID: 6932 RVA: 0x00080EA8 File Offset: 0x0007F0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026543, XrefRangeEnd = 1026548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionT<T>.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B15 RID: 6933 RVA: 0x00080EF8 File Offset: 0x0007F0F8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CastInstructionT()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastInstruction.CastInstructionT<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionT<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B16 RID: 6934 RVA: 0x0000A50B File Offset: 0x0000870B
			public CastInstructionT(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001251 RID: 4689
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001252 RID: 4690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000329 RID: 809
		public class CastInstructionNoT : CastInstruction
		{
			// Token: 0x06001B17 RID: 6935 RVA: 0x00080F34 File Offset: 0x0007F134
			// Note: this type is marked as 'beforefieldinit'.
			static CastInstructionNoT()
			{
				Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastInstruction>.NativeClassPtr, "CastInstructionNoT");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr);
				CastInstruction.CastInstructionNoT.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, "_t");
				CastInstruction.CastInstructionNoT.NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, 100666211);
				CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_Create_Public_Static_CastInstruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, 100666212);
				CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, 100666213);
				CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_ConvertNull_Protected_Abstract_Virtual_New_Void_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, 100666214);
			}

			// Token: 0x06001B18 RID: 6936 RVA: 0x00080FC4 File Offset: 0x0007F1C4
			[CallerCount(96)]
			[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CastInstructionNoT(Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B19 RID: 6937 RVA: 0x00081010 File Offset: 0x0007F210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026555, XrefRangeEnd = 1026567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe static CastInstruction Create(Type t)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_Create_Public_Static_CastInstruction_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CastInstruction>(intPtr3) : null;
				}
			}

			// Token: 0x06001B1A RID: 6938 RVA: 0x00081054 File Offset: 0x0007F254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026567, XrefRangeEnd = 1026578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B1B RID: 6939 RVA: 0x000810AC File Offset: 0x0007F2AC
			[CallerCount(0)]
			public unsafe virtual void ConvertNull(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CastInstruction.CastInstructionNoT.NativeMethodInfoPtr_ConvertNull_Protected_Abstract_Virtual_New_Void_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1C RID: 6940 RVA: 0x0000A514 File Offset: 0x00008714
			public CastInstructionNoT(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000810FC File Offset: 0x0007F2FC
			// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000A51D File Offset: 0x0000871D
			public unsafe Type _t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastInstruction.CastInstructionNoT.NativeFieldInfoPtr__t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastInstruction.CastInstructionNoT.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001253 RID: 4691
			private static readonly IntPtr NativeFieldInfoPtr__t;

			// Token: 0x04001254 RID: 4692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;

			// Token: 0x04001255 RID: 4693
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CastInstruction_Type_0;

			// Token: 0x04001256 RID: 4694
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001257 RID: 4695
			private static readonly IntPtr NativeMethodInfoPtr_ConvertNull_Protected_Abstract_Virtual_New_Void_InterpretedFrame_0;

			// Token: 0x02000369 RID: 873
			public sealed class Ref : CastInstruction.CastInstructionNoT
			{
				// Token: 0x06001C7B RID: 7291 RVA: 0x000860AC File Offset: 0x000842AC
				// Note: this type is marked as 'beforefieldinit'.
				static Ref()
				{
					Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, "Ref");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Ref>.NativeClassPtr);
					CastInstruction.CastInstructionNoT.Ref.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Ref>.NativeClassPtr, 100666215);
					CastInstruction.CastInstructionNoT.Ref.NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Ref>.NativeClassPtr, 100666216);
				}

				// Token: 0x06001C7C RID: 7292 RVA: 0x00086100 File Offset: 0x00084300
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Ref(Type t)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Ref>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.Ref.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C7D RID: 7293 RVA: 0x0008614C File Offset: 0x0008434C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026548, XrefRangeEnd = 1026550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void ConvertNull(InterpretedFrame frame)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.Ref.NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C7E RID: 7294 RVA: 0x0000AE42 File Offset: 0x00009042
				public Ref(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001333 RID: 4915
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

				// Token: 0x04001334 RID: 4916
				private static readonly IntPtr NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0;
			}

			// Token: 0x0200036A RID: 874
			public sealed class Value : CastInstruction.CastInstructionNoT
			{
				// Token: 0x06001C7F RID: 7295 RVA: 0x00086190 File Offset: 0x00084390
				// Note: this type is marked as 'beforefieldinit'.
				static Value()
				{
					Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT>.NativeClassPtr, "Value");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Value>.NativeClassPtr);
					CastInstruction.CastInstructionNoT.Value.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Value>.NativeClassPtr, 100666217);
					CastInstruction.CastInstructionNoT.Value.NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Value>.NativeClassPtr, 100666218);
				}

				// Token: 0x06001C80 RID: 7296 RVA: 0x000861E4 File Offset: 0x000843E4
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Value(Type t)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastInstruction.CastInstructionNoT.Value>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.Value.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C81 RID: 7297 RVA: 0x00086230 File Offset: 0x00084430
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026550, XrefRangeEnd = 1026555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void ConvertNull(InterpretedFrame frame)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CastInstruction.CastInstructionNoT.Value.NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C82 RID: 7298 RVA: 0x0000AE4B File Offset: 0x0000904B
				public Value(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001335 RID: 4917
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

				// Token: 0x04001336 RID: 4918
				private static readonly IntPtr NativeMethodInfoPtr_ConvertNull_Protected_Virtual_Void_InterpretedFrame_0;
			}
		}
	}
}
