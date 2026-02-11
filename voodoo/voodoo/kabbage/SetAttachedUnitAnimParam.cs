using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000027 RID: 39
	public class SetAttachedUnitAnimParam : MonoBehaviour
	{
		// Token: 0x06000158 RID: 344 RVA: 0x0000D358 File Offset: 0x0000B558
		// Note: this type is marked as 'beforefieldinit'.
		static SetAttachedUnitAnimParam()
		{
			Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "SetAttachedUnitAnimParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr);
			SetAttachedUnitAnimParam.NativeFieldInfoPtr_kabbage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "kabbage");
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663431);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetTrue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663432);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetFalse_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663433);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_animSetBool_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663434);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_setBool_Private_Void_Il2CppReferenceArray_1_Animator_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663435);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663436);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_setTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663437);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663438);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_resetTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663439);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr_getAnimators_Private_Il2CppReferenceArray_1_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663440);
			SetAttachedUnitAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, 100663441);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000D478 File Offset: 0x0000B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107190, XrefRangeEnd = 1107194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107194, XrefRangeEnd = 1107195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetTrue(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetTrue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107195, XrefRangeEnd = 1107196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetFalse(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetFalse_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000D534 File Offset: 0x0000B734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107228, RefRangeEnd = 1107230, XrefRangeStart = 1107196, XrefRangeEnd = 1107228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void animSetBool(string param, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_animSetBool_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000D584 File Offset: 0x0000B784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107277, RefRangeEnd = 1107278, XrefRangeStart = 1107230, XrefRangeEnd = 1107277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setBool(Il2CppReferenceArray<Animator> animators, string param, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animators);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(param);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_setBool_Private_Void_Il2CppReferenceArray_1_Animator_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107278, XrefRangeEnd = 1107312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetTrigger(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000D62C File Offset: 0x0000B82C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107359, RefRangeEnd = 1107361, XrefRangeStart = 1107312, XrefRangeEnd = 1107359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setTrigger(Il2CppReferenceArray<Animator> animators, string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animators);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(param);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_setTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D680 File Offset: 0x0000B880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107361, XrefRangeEnd = 1107395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetTrigger(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107442, RefRangeEnd = 1107444, XrefRangeStart = 1107395, XrefRangeEnd = 1107442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resetTrigger(Il2CppReferenceArray<Animator> animators, string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animators);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(param);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_resetTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D718 File Offset: 0x0000B918
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1107460, RefRangeEnd = 1107466, XrefRangeStart = 1107444, XrefRangeEnd = 1107460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Animator> getAnimators()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr_getAnimators_Private_Il2CppReferenceArray_1_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr3) : null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D758 File Offset: 0x0000B958
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAttachedUnitAnimParam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002C2C File Offset: 0x00000E2C
		public SetAttachedUnitAnimParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000D794 File Offset: 0x0000B994
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002C35 File Offset: 0x00000E35
		public unsafe VoodooRenderAnimator kabbage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.NativeFieldInfoPtr_kabbage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.NativeFieldInfoPtr_kabbage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_kabbage;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetTrue_Public_Void_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetFalse_Public_Void_String_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_animSetBool_Private_Void_String_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_setBool_Private_Void_Il2CppReferenceArray_1_Animator_String_Boolean_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetTrigger_Public_Void_String_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_setTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetTrigger_Public_Void_String_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_resetTrigger_Private_Void_Il2CppReferenceArray_1_Animator_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_getAnimators_Private_Il2CppReferenceArray_1_Animator_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B6 RID: 182
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A2F RID: 2607 RVA: 0x0002B178 File Offset: 0x00029378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, "animators");
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, "value");
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, 100663442);
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__animSetBool_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, 100663443);
				SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__animSetBool_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr, 100663444);
			}

			// Token: 0x06000A30 RID: 2608 RVA: 0x0002B230 File Offset: 0x00029430
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A31 RID: 2609 RVA: 0x0002B26C File Offset: 0x0002946C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107146, XrefRangeEnd = 1107153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _animSetBool_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__animSetBool_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A32 RID: 2610 RVA: 0x0002B2A8 File Offset: 0x000294A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107153, XrefRangeEnd = 1107154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _animSetBool_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeMethodInfoPtr__animSetBool_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x00006F9F File Offset: 0x0000519F
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002B2DC File Offset: 0x000294DC
			// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00006FA8 File Offset: 0x000051A8
			public unsafe Il2CppReferenceArray<Animator> animators
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_animators);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002B30C File Offset: 0x0002950C
			// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00006FC7 File Offset: 0x000051C7
			public unsafe SetAttachedUnitAnimParam __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0002B33C File Offset: 0x0002953C
			// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00006FE6 File Offset: 0x000051E6
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002B364 File Offset: 0x00029564
			// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00007005 File Offset: 0x00005205
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass4_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x04000652 RID: 1618
			private static readonly IntPtr NativeFieldInfoPtr_animators;

			// Token: 0x04000653 RID: 1619
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000654 RID: 1620
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x04000655 RID: 1621
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000656 RID: 1622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000657 RID: 1623
			private static readonly IntPtr NativeMethodInfoPtr__animSetBool_b__0_Internal_Boolean_0;

			// Token: 0x04000658 RID: 1624
			private static readonly IntPtr NativeMethodInfoPtr__animSetBool_b__1_Internal_Void_0;
		}

		// Token: 0x020000B7 RID: 183
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A3C RID: 2620 RVA: 0x0002B38C File Offset: 0x0002958C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr, "value");
				SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr, "<>9__0");
				SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr, 100663445);
				SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeMethodInfoPtr__setBool_b__0_Internal_Boolean_AnimatorControllerParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr, 100663446);
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x0002B41C File Offset: 0x0002961C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x0002B458 File Offset: 0x00029658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107154, XrefRangeEnd = 1107157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setBool_b__0(AnimatorControllerParameter p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeMethodInfoPtr__setBool_b__0_Internal_Boolean_AnimatorControllerParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x00007020 File Offset: 0x00005220
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0002B4A8 File Offset: 0x000296A8
			// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00007029 File Offset: 0x00005229
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0002B4D0 File Offset: 0x000296D0
			// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00007048 File Offset: 0x00005248
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0002B4F8 File Offset: 0x000296F8
			// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00007063 File Offset: 0x00005263
			public unsafe Func<AnimatorControllerParameter, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AnimatorControllerParameter, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000659 RID: 1625
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x0400065A RID: 1626
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400065B RID: 1627
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x0400065C RID: 1628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400065D RID: 1629
			private static readonly IntPtr NativeMethodInfoPtr__setBool_b__0_Internal_Boolean_AnimatorControllerParameter_0;
		}

		// Token: 0x020000B8 RID: 184
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A46 RID: 2630 RVA: 0x0002B528 File Offset: 0x00029728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr, "animator");
				SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr, "CS$<>8__locals1");
				SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr, 100663447);
				SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__setBool_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr, 100663448);
				SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__setBool_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr, 100663449);
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x0002B5B8 File Offset: 0x000297B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A48 RID: 2632 RVA: 0x0002B5F4 File Offset: 0x000297F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107157, XrefRangeEnd = 1107159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setBool_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__setBool_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A49 RID: 2633 RVA: 0x0002B630 File Offset: 0x00029830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107159, XrefRangeEnd = 1107161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _setBool_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeMethodInfoPtr__setBool_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x00007082 File Offset: 0x00005282
			public __c__DisplayClass5_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0002B664 File Offset: 0x00029864
			// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0000708B File Offset: 0x0000528B
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002B694 File Offset: 0x00029894
			// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000070AA File Offset: 0x000052AA
			public unsafe SetAttachedUnitAnimParam.__c__DisplayClass5_0 field_Public___c__DisplayClass5_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400065E RID: 1630
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x0400065F RID: 1631
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0;

			// Token: 0x04000660 RID: 1632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000661 RID: 1633
			private static readonly IntPtr NativeMethodInfoPtr__setBool_b__1_Internal_Boolean_0;

			// Token: 0x04000662 RID: 1634
			private static readonly IntPtr NativeMethodInfoPtr__setBool_b__2_Internal_Void_0;
		}

		// Token: 0x020000B9 RID: 185
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A4F RID: 2639 RVA: 0x0002B6C4 File Offset: 0x000298C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, "animators");
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, 100663450);
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__Event_SetTrigger_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, 100663451);
				SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__Event_SetTrigger_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr, 100663452);
			}

			// Token: 0x06000A50 RID: 2640 RVA: 0x0002B768 File Offset: 0x00029968
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A51 RID: 2641 RVA: 0x0002B7A4 File Offset: 0x000299A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107161, XrefRangeEnd = 1107168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_SetTrigger_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__Event_SetTrigger_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x0002B7E0 File Offset: 0x000299E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107168, XrefRangeEnd = 1107170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_SetTrigger_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeMethodInfoPtr__Event_SetTrigger_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x000070C9 File Offset: 0x000052C9
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002B814 File Offset: 0x00029A14
			// (set) Token: 0x06000A55 RID: 2645 RVA: 0x000070D2 File Offset: 0x000052D2
			public unsafe Il2CppReferenceArray<Animator> animators
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_animators);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002B844 File Offset: 0x00029A44
			// (set) Token: 0x06000A57 RID: 2647 RVA: 0x000070F1 File Offset: 0x000052F1
			public unsafe SetAttachedUnitAnimParam __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002B874 File Offset: 0x00029A74
			// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00007110 File Offset: 0x00005310
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass6_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000663 RID: 1635
			private static readonly IntPtr NativeFieldInfoPtr_animators;

			// Token: 0x04000664 RID: 1636
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000665 RID: 1637
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x04000666 RID: 1638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000667 RID: 1639
			private static readonly IntPtr NativeMethodInfoPtr__Event_SetTrigger_b__0_Internal_Boolean_0;

			// Token: 0x04000668 RID: 1640
			private static readonly IntPtr NativeMethodInfoPtr__Event_SetTrigger_b__1_Internal_Void_0;
		}

		// Token: 0x020000BA RID: 186
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A5A RID: 2650 RVA: 0x0002B89C File Offset: 0x00029A9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr, "<>9__0");
				SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr, 100663453);
				SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeMethodInfoPtr__setTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr, 100663454);
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x0002B918 File Offset: 0x00029B18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x0002B954 File Offset: 0x00029B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setTrigger_b__0(AnimatorControllerParameter p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeMethodInfoPtr__setTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x0000712F File Offset: 0x0000532F
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002B9A4 File Offset: 0x00029BA4
			// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00007138 File Offset: 0x00005338
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002B9CC File Offset: 0x00029BCC
			// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00007157 File Offset: 0x00005357
			public unsafe Func<AnimatorControllerParameter, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AnimatorControllerParameter, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000669 RID: 1641
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x0400066A RID: 1642
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x0400066B RID: 1643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400066C RID: 1644
			private static readonly IntPtr NativeMethodInfoPtr__setTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0;
		}

		// Token: 0x020000BB RID: 187
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A62 RID: 2658 RVA: 0x0002B9FC File Offset: 0x00029BFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr, "animator");
				SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr, 100663455);
				SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__setTrigger_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr, 100663456);
				SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__setTrigger_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr, 100663457);
			}

			// Token: 0x06000A63 RID: 2659 RVA: 0x0002BA8C File Offset: 0x00029C8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x0002BAC8 File Offset: 0x00029CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setTrigger_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__setTrigger_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x0002BB04 File Offset: 0x00029D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107170, XrefRangeEnd = 1107172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _setTrigger_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeMethodInfoPtr__setTrigger_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x00007176 File Offset: 0x00005376
			public __c__DisplayClass7_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0002BB38 File Offset: 0x00029D38
			// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000717F File Offset: 0x0000537F
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002BB68 File Offset: 0x00029D68
			// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000719E File Offset: 0x0000539E
			public unsafe SetAttachedUnitAnimParam.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400066D RID: 1645
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x0400066E RID: 1646
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x0400066F RID: 1647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000670 RID: 1648
			private static readonly IntPtr NativeMethodInfoPtr__setTrigger_b__1_Internal_Boolean_0;

			// Token: 0x04000671 RID: 1649
			private static readonly IntPtr NativeMethodInfoPtr__setTrigger_b__2_Internal_Void_0;
		}

		// Token: 0x020000BC RID: 188
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A6B RID: 2667 RVA: 0x0002BB98 File Offset: 0x00029D98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, "animators");
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, 100663458);
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__Event_ResetTrigger_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, 100663459);
				SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__Event_ResetTrigger_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr, 100663460);
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x0002BC3C File Offset: 0x00029E3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x0002BC78 File Offset: 0x00029E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107172, XrefRangeEnd = 1107179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ResetTrigger_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__Event_ResetTrigger_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x0002BCB4 File Offset: 0x00029EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107179, XrefRangeEnd = 1107181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_ResetTrigger_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeMethodInfoPtr__Event_ResetTrigger_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x000071BD File Offset: 0x000053BD
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002BCE8 File Offset: 0x00029EE8
			// (set) Token: 0x06000A71 RID: 2673 RVA: 0x000071C6 File Offset: 0x000053C6
			public unsafe Il2CppReferenceArray<Animator> animators
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_animators);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002BD18 File Offset: 0x00029F18
			// (set) Token: 0x06000A73 RID: 2675 RVA: 0x000071E5 File Offset: 0x000053E5
			public unsafe SetAttachedUnitAnimParam __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002BD48 File Offset: 0x00029F48
			// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00007204 File Offset: 0x00005404
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass8_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000672 RID: 1650
			private static readonly IntPtr NativeFieldInfoPtr_animators;

			// Token: 0x04000673 RID: 1651
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000674 RID: 1652
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x04000675 RID: 1653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000676 RID: 1654
			private static readonly IntPtr NativeMethodInfoPtr__Event_ResetTrigger_b__0_Internal_Boolean_0;

			// Token: 0x04000677 RID: 1655
			private static readonly IntPtr NativeMethodInfoPtr__Event_ResetTrigger_b__1_Internal_Void_0;
		}

		// Token: 0x020000BD RID: 189
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A76 RID: 2678 RVA: 0x0002BD70 File Offset: 0x00029F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr, "param");
				SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr, "<>9__0");
				SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr, 100663461);
				SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeMethodInfoPtr__resetTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr, 100663462);
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x0002BDEC File Offset: 0x00029FEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x0002BE28 File Offset: 0x0002A028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _resetTrigger_b__0(AnimatorControllerParameter p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeMethodInfoPtr__resetTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x00007223 File Offset: 0x00005423
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002BE78 File Offset: 0x0002A078
			// (set) Token: 0x06000A7B RID: 2683 RVA: 0x0000722C File Offset: 0x0000542C
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
			// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0000724B File Offset: 0x0000544B
			public unsafe Func<AnimatorControllerParameter, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AnimatorControllerParameter, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000678 RID: 1656
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x04000679 RID: 1657
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x0400067A RID: 1658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400067B RID: 1659
			private static readonly IntPtr NativeMethodInfoPtr__resetTrigger_b__0_Internal_Boolean_AnimatorControllerParameter_0;
		}

		// Token: 0x020000BE RID: 190
		[ObfuscatedName("voodoo.kabbage.SetAttachedUnitAnimParam+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A7E RID: 2686 RVA: 0x0002BED0 File Offset: 0x0002A0D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAttachedUnitAnimParam>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr);
				SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr, "animator");
				SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr, "CS$<>8__locals1");
				SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr, 100663463);
				SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__resetTrigger_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr, 100663464);
				SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__resetTrigger_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr, 100663465);
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x0002BF60 File Offset: 0x0002A160
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAttachedUnitAnimParam.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x0002BF9C File Offset: 0x0002A19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _resetTrigger_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__resetTrigger_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000A81 RID: 2689 RVA: 0x0002BFD8 File Offset: 0x0002A1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107181, XrefRangeEnd = 1107190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _resetTrigger_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeMethodInfoPtr__resetTrigger_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A82 RID: 2690 RVA: 0x0000726A File Offset: 0x0000546A
			public __c__DisplayClass9_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0002C00C File Offset: 0x0002A20C
			// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00007273 File Offset: 0x00005473
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002C03C File Offset: 0x0002A23C
			// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00007292 File Offset: 0x00005492
			public unsafe SetAttachedUnitAnimParam.__c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAttachedUnitAnimParam.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAttachedUnitAnimParam.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400067C RID: 1660
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x0400067D RID: 1661
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;

			// Token: 0x0400067E RID: 1662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400067F RID: 1663
			private static readonly IntPtr NativeMethodInfoPtr__resetTrigger_b__1_Internal_Boolean_0;

			// Token: 0x04000680 RID: 1664
			private static readonly IntPtr NativeMethodInfoPtr__resetTrigger_b__2_Internal_Void_0;
		}
	}
}
