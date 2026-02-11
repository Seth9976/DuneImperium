using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.skirmishScripts
{
	// Token: 0x02000051 RID: 81
	public class SkirmishScoreItem : Object
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScoreItem()
		{
			Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishScoreItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr);
			SkirmishScoreItem.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, "Value");
			SkirmishScoreItem.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, "Prompt");
			SkirmishScoreItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, 100664296);
			SkirmishScoreItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, 100664297);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002C774 File Offset: 0x0002A974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553822, XrefRangeEnd = 553828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishScoreItem(int value, string prompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoreItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553828, XrefRangeEnd = 553836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoreItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000042B7 File Offset: 0x000024B7
		public SkirmishScoreItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0002C814 File Offset: 0x0002AA14
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x000042C0 File Offset: 0x000024C0
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0002C83C File Offset: 0x0002AA3C
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x000042DB File Offset: 0x000024DB
		public unsafe LocalizableTextVariables Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
