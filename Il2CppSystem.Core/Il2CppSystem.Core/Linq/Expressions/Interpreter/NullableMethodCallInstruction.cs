using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000100 RID: 256
	public class NullableMethodCallInstruction : Instruction
	{
		// Token: 0x06000F78 RID: 3960 RVA: 0x00052480 File Offset: 0x00050680
		// Note: this type is marked as 'beforefieldinit'.
		static NullableMethodCallInstruction()
		{
			Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NullableMethodCallInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr);
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_hasValue");
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_value");
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_equals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_equals");
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_getHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_getHashCode");
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_getValueOrDefault1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_getValueOrDefault1");
			NullableMethodCallInstruction.NativeFieldInfoPtr_s_toString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "s_toString");
			NullableMethodCallInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666182);
			NullableMethodCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666183);
			NullableMethodCallInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666184);
			NullableMethodCallInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666185);
			NullableMethodCallInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_String_Int32_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666186);
			NullableMethodCallInstruction.NativeMethodInfoPtr_CreateGetValue_Public_Static_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, 100666187);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000525A0 File Offset: 0x000507A0
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableMethodCallInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x000525E8 File Offset: 0x000507E8
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableMethodCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00052630 File Offset: 0x00050830
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026505, XrefRangeEnd = 1026507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableMethodCallInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00052674 File Offset: 0x00050874
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullableMethodCallInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000526B0 File Offset: 0x000508B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1026530, RefRangeEnd = 1026533, XrefRangeStart = 1026507, XrefRangeEnd = 1026530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(string method, int argCount, MethodInfo mi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_String_Int32_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00052714 File Offset: 0x00050914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026542, RefRangeEnd = 1026543, XrefRangeStart = 1026533, XrefRangeEnd = 1026542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction CreateGetValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.NativeMethodInfoPtr_CreateGetValue_Public_Static_Instruction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00006C72 File Offset: 0x00004E72
		public NullableMethodCallInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00052748 File Offset: 0x00050948
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00006C7B File Offset: 0x00004E7B
		public unsafe static NullableMethodCallInstruction s_hasValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_hasValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_hasValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00052770 File Offset: 0x00050970
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00006C8D File Offset: 0x00004E8D
		public unsafe static NullableMethodCallInstruction s_value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00052798 File Offset: 0x00050998
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00006C9F File Offset: 0x00004E9F
		public unsafe static NullableMethodCallInstruction s_equals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_equals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_equals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000527C0 File Offset: 0x000509C0
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00006CB1 File Offset: 0x00004EB1
		public unsafe static NullableMethodCallInstruction s_getHashCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_getHashCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_getHashCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000527E8 File Offset: 0x000509E8
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00006CC3 File Offset: 0x00004EC3
		public unsafe static NullableMethodCallInstruction s_getValueOrDefault1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_getValueOrDefault1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_getValueOrDefault1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00052810 File Offset: 0x00050A10
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00006CD5 File Offset: 0x00004ED5
		public unsafe static NullableMethodCallInstruction s_toString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_toString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullableMethodCallInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullableMethodCallInstruction.NativeFieldInfoPtr_s_toString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_s_hasValue;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_s_value;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_s_equals;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_s_getHashCode;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_s_getValueOrDefault1;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeFieldInfoPtr_s_toString;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_String_Int32_MethodInfo_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_CreateGetValue_Public_Static_Instruction_0;

		// Token: 0x02000321 RID: 801
		public sealed class HasValue : NullableMethodCallInstruction
		{
			// Token: 0x06001AF3 RID: 6899 RVA: 0x00080704 File Offset: 0x0007E904
			// Note: this type is marked as 'beforefieldinit'.
			static HasValue()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.HasValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "HasValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.HasValue>.NativeClassPtr);
				NullableMethodCallInstruction.HasValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.HasValue>.NativeClassPtr, 100666188);
				NullableMethodCallInstruction.HasValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.HasValue>.NativeClassPtr, 100666189);
			}

			// Token: 0x06001AF4 RID: 6900 RVA: 0x00080758 File Offset: 0x0007E958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026476, XrefRangeEnd = 1026478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.HasValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AF5 RID: 6901 RVA: 0x000807A8 File Offset: 0x0007E9A8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HasValue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.HasValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.HasValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AF6 RID: 6902 RVA: 0x0000A4AD File Offset: 0x000086AD
			public HasValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000322 RID: 802
		public sealed class GetValue : NullableMethodCallInstruction
		{
			// Token: 0x06001AF7 RID: 6903 RVA: 0x000807E4 File Offset: 0x0007E9E4
			// Note: this type is marked as 'beforefieldinit'.
			static GetValue()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.GetValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "GetValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValue>.NativeClassPtr);
				NullableMethodCallInstruction.GetValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValue>.NativeClassPtr, 100666190);
				NullableMethodCallInstruction.GetValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValue>.NativeClassPtr, 100666191);
			}

			// Token: 0x06001AF8 RID: 6904 RVA: 0x00080838 File Offset: 0x0007EA38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026478, XrefRangeEnd = 1026480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AF9 RID: 6905 RVA: 0x00080888 File Offset: 0x0007EA88
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetValue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x0000A4B6 File Offset: 0x000086B6
			public GetValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001243 RID: 4675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000323 RID: 803
		public sealed class GetValueOrDefault : NullableMethodCallInstruction
		{
			// Token: 0x06001AFB RID: 6907 RVA: 0x000808C4 File Offset: 0x0007EAC4
			// Note: this type is marked as 'beforefieldinit'.
			static GetValueOrDefault()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "GetValueOrDefault");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr);
				NullableMethodCallInstruction.GetValueOrDefault.NativeFieldInfoPtr__defaultValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr, "_defaultValueType");
				NullableMethodCallInstruction.GetValueOrDefault.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr, 100666192);
				NullableMethodCallInstruction.GetValueOrDefault.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr, 100666193);
			}

			// Token: 0x06001AFC RID: 6908 RVA: 0x0008092C File Offset: 0x0007EB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026480, XrefRangeEnd = 1026483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetValueOrDefault(MethodInfo mi)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValueOrDefault.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AFD RID: 6909 RVA: 0x00080978 File Offset: 0x0007EB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026483, XrefRangeEnd = 1026487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValueOrDefault.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AFE RID: 6910 RVA: 0x0000A4BF File Offset: 0x000086BF
			public GetValueOrDefault(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000809C8 File Offset: 0x0007EBC8
			// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000A4C8 File Offset: 0x000086C8
			public unsafe Type _defaultValueType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableMethodCallInstruction.GetValueOrDefault.NativeFieldInfoPtr__defaultValueType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableMethodCallInstruction.GetValueOrDefault.NativeFieldInfoPtr__defaultValueType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001244 RID: 4676
			private static readonly IntPtr NativeFieldInfoPtr__defaultValueType;

			// Token: 0x04001245 RID: 4677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0;

			// Token: 0x04001246 RID: 4678
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000324 RID: 804
		public sealed class GetValueOrDefault1 : NullableMethodCallInstruction
		{
			// Token: 0x06001B01 RID: 6913 RVA: 0x000809F8 File Offset: 0x0007EBF8
			// Note: this type is marked as 'beforefieldinit'.
			static GetValueOrDefault1()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "GetValueOrDefault1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr);
				NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr, 100666194);
				NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr, 100666195);
				NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr, 100666196);
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00080A60 File Offset: 0x0007EC60
			public unsafe override int ConsumedStack
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B03 RID: 6915 RVA: 0x00080A9C File Offset: 0x0007EC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026487, XrefRangeEnd = 1026490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B04 RID: 6916 RVA: 0x00080AEC File Offset: 0x0007ECEC
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetValueOrDefault1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.GetValueOrDefault1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetValueOrDefault1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B05 RID: 6917 RVA: 0x0000A4E7 File Offset: 0x000086E7
			public GetValueOrDefault1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000325 RID: 805
		public sealed class EqualsClass : NullableMethodCallInstruction
		{
			// Token: 0x06001B06 RID: 6918 RVA: 0x00080B28 File Offset: 0x0007ED28
			// Note: this type is marked as 'beforefieldinit'.
			static EqualsClass()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "EqualsClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr);
				NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr, 100666197);
				NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr, 100666198);
				NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr, 100666199);
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00080B90 File Offset: 0x0007ED90
			public unsafe override int ConsumedStack
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B08 RID: 6920 RVA: 0x00080BCC File Offset: 0x0007EDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026490, XrefRangeEnd = 1026498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x00080C1C File Offset: 0x0007EE1C
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualsClass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.EqualsClass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.EqualsClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x0000A4F0 File Offset: 0x000086F0
			public EqualsClass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000326 RID: 806
		public sealed class ToStringClass : NullableMethodCallInstruction
		{
			// Token: 0x06001B0B RID: 6923 RVA: 0x00080C58 File Offset: 0x0007EE58
			// Note: this type is marked as 'beforefieldinit'.
			static ToStringClass()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.ToStringClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "ToStringClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.ToStringClass>.NativeClassPtr);
				NullableMethodCallInstruction.ToStringClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.ToStringClass>.NativeClassPtr, 100666200);
				NullableMethodCallInstruction.ToStringClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.ToStringClass>.NativeClassPtr, 100666201);
			}

			// Token: 0x06001B0C RID: 6924 RVA: 0x00080CAC File Offset: 0x0007EEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026498, XrefRangeEnd = 1026503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.ToStringClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B0D RID: 6925 RVA: 0x00080CFC File Offset: 0x0007EEFC
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToStringClass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.ToStringClass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.ToStringClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0E RID: 6926 RVA: 0x0000A4F9 File Offset: 0x000086F9
			public ToStringClass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000327 RID: 807
		public sealed class GetHashCodeClass : NullableMethodCallInstruction
		{
			// Token: 0x06001B0F RID: 6927 RVA: 0x00080D38 File Offset: 0x0007EF38
			// Note: this type is marked as 'beforefieldinit'.
			static GetHashCodeClass()
			{
				Il2CppClassPointerStore<NullableMethodCallInstruction.GetHashCodeClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NullableMethodCallInstruction>.NativeClassPtr, "GetHashCodeClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableMethodCallInstruction.GetHashCodeClass>.NativeClassPtr);
				NullableMethodCallInstruction.GetHashCodeClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetHashCodeClass>.NativeClassPtr, 100666202);
				NullableMethodCallInstruction.GetHashCodeClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableMethodCallInstruction.GetHashCodeClass>.NativeClassPtr, 100666203);
			}

			// Token: 0x06001B10 RID: 6928 RVA: 0x00080D8C File Offset: 0x0007EF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026503, XrefRangeEnd = 1026505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetHashCodeClass.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B11 RID: 6929 RVA: 0x00080DDC File Offset: 0x0007EFDC
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetHashCodeClass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableMethodCallInstruction.GetHashCodeClass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableMethodCallInstruction.GetHashCodeClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B12 RID: 6930 RVA: 0x0000A502 File Offset: 0x00008702
			public GetHashCodeClass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001250 RID: 4688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
