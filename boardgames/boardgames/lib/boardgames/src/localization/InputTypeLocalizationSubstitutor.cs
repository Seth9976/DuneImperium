using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.boardgames.src.localization
{
	// Token: 0x02000040 RID: 64
	public class InputTypeLocalizationSubstitutor : MonoBehaviour
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00019510 File Offset: 0x00017710
		// Note: this type is marked as 'beforefieldinit'.
		static InputTypeLocalizationSubstitutor()
		{
			Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.boardgames.src.localization", "InputTypeLocalizationSubstitutor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr);
			InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_touchSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, "touchSuffix");
			InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_mouseKeySuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, "mouseKeySuffix");
			InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_gamepadSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, "gamepadSuffix");
			InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_switchGamepadSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, "switchGamepadSuffix");
			InputTypeLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, 100663768);
			InputTypeLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr, 100663769);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000195B8 File Offset: 0x000177B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985191, XrefRangeEnd = 985219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Substitute(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTypeLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00019600 File Offset: 0x00017800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985219, XrefRangeEnd = 985236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputTypeLocalizationSubstitutor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputTypeLocalizationSubstitutor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTypeLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003173 File Offset: 0x00001373
		public InputTypeLocalizationSubstitutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0001963C File Offset: 0x0001783C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000317C File Offset: 0x0000137C
		public unsafe string touchSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_touchSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_touchSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00019664 File Offset: 0x00017864
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000319B File Offset: 0x0000139B
		public unsafe string mouseKeySuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_mouseKeySuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_mouseKeySuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0001968C File Offset: 0x0001788C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000031BA File Offset: 0x000013BA
		public unsafe string gamepadSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_gamepadSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_gamepadSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000196B4 File Offset: 0x000178B4
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000031D9 File Offset: 0x000013D9
		public unsafe string switchGamepadSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_switchGamepadSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputTypeLocalizationSubstitutor.NativeFieldInfoPtr_switchGamepadSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_touchSuffix;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_mouseKeySuffix;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_gamepadSuffix;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_switchGamepadSuffix;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
