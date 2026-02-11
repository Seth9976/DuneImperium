using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.save
{
	// Token: 0x020000C0 RID: 192
	public class SaveOne : SaveRequest
	{
		// Token: 0x06000C1D RID: 3101 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		// Note: this type is marked as 'beforefieldinit'.
		static SaveOne()
		{
			Il2CppClassPointerStore<SaveOne>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.save", "SaveOne");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveOne>.NativeClassPtr);
			SaveOne.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveOne>.NativeClassPtr, "key");
			SaveOne.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveOne>.NativeClassPtr, "value");
			SaveOne.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveOne>.NativeClassPtr, 100665006);
			SaveOne.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveOne>.NativeClassPtr, 100665007);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00041E58 File Offset: 0x00040058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864262, RefRangeEnd = 864263, XrefRangeStart = 864261, XrefRangeEnd = 864262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveOne(int key, int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveOne>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveOne.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00041EB0 File Offset: 0x000400B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864263, XrefRangeEnd = 864266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyTo(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveOne.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000064C9 File Offset: 0x000046C9
		public SaveOne(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00041F00 File Offset: 0x00040100
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x000064D2 File Offset: 0x000046D2
		public unsafe int key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveOne.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveOne.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00041F28 File Offset: 0x00040128
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x000064ED File Offset: 0x000046ED
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveOne.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveOne.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0;
	}
}
