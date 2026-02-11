using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.save
{
	// Token: 0x020000C1 RID: 193
	public class SaveRequest : Object
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x00041F50 File Offset: 0x00040150
		// Note: this type is marked as 'beforefieldinit'.
		static SaveRequest()
		{
			Il2CppClassPointerStore<SaveRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.save", "SaveRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr);
			SaveRequest.NativeFieldInfoPtr__Completed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "<Completed>k__BackingField");
			SaveRequest.NativeFieldInfoPtr__Success_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "<Success>k__BackingField");
			SaveRequest.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665008);
			SaveRequest.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665009);
			SaveRequest.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665010);
			SaveRequest.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665011);
			SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665012);
			SaveRequest.NativeMethodInfoPtr_ApplyTo_Public_Abstract_Virtual_New_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665013);
			SaveRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665014);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00042034 File Offset: 0x00040234
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x00042070 File Offset: 0x00040270
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000420B0 File Offset: 0x000402B0
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000420EC File Offset: 0x000402EC
		public unsafe virtual bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0004212C File Offset: 0x0004032C
		[CallerCount(0)]
		public unsafe void Complete(bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0004216C File Offset: 0x0004036C
		[CallerCount(0)]
		public unsafe virtual void ApplyTo(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveRequest.NativeMethodInfoPtr_ApplyTo_Public_Abstract_Virtual_New_Void_IDictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000421BC File Offset: 0x000403BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00006508 File Offset: 0x00004708
		public SaveRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000421F8 File Offset: 0x000403F8
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00006511 File Offset: 0x00004711
		public unsafe bool _Completed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__Completed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__Completed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00042220 File Offset: 0x00040420
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0000652C File Offset: 0x0000472C
		public unsafe bool _Success_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__Success_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__Success_k__BackingField)) = value;
			}
		}

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr__Completed_k__BackingField;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr__Success_k__BackingField;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Boolean_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Public_Abstract_Virtual_New_Void_IDictionary_2_Int32_Int32_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
