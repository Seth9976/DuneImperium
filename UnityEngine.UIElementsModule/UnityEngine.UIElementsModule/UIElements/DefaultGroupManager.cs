using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000140 RID: 320
	public class DefaultGroupManager : Object
	{
		// Token: 0x060017BB RID: 6075 RVA: 0x00071094 File Offset: 0x0006F294
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultGroupManager()
		{
			Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultGroupManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr);
			DefaultGroupManager.NativeFieldInfoPtr_m_GroupOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, "m_GroupOptions");
			DefaultGroupManager.NativeFieldInfoPtr_m_SelectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, "m_SelectedOption");
			DefaultGroupManager.NativeFieldInfoPtr_m_GroupBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, "m_GroupBox");
			DefaultGroupManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IGroupBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, 100666830);
			DefaultGroupManager.NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, 100666831);
			DefaultGroupManager.NativeMethodInfoPtr_RegisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, 100666832);
			DefaultGroupManager.NativeMethodInfoPtr_UnregisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, 100666833);
			DefaultGroupManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr, 100666834);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00071164 File Offset: 0x0006F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(IGroupBox groupBox)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupBox);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGroupManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IGroupBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000711A8 File Offset: 0x0006F3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319318, XrefRangeEnd = 319337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOptionSelectionChanged(IGroupBoxOption selectedOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedOption);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGroupManager.NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000711EC File Offset: 0x0006F3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319337, XrefRangeEnd = 319348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterOption(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGroupManager.NativeMethodInfoPtr_RegisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00071230 File Offset: 0x0006F430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319348, XrefRangeEnd = 319355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterOption(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGroupManager.NativeMethodInfoPtr_UnregisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00071274 File Offset: 0x0006F474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319355, XrefRangeEnd = 319379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultGroupManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultGroupManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultGroupManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0000AEE5 File Offset: 0x000090E5
		public DefaultGroupManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000712B0 File Offset: 0x0006F4B0
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000AEEE File Offset: 0x000090EE
		public unsafe List<IGroupBoxOption> m_GroupOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_GroupOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGroupBoxOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_GroupOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x000712E0 File Offset: 0x0006F4E0
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000AF0D File Offset: 0x0000910D
		public unsafe IGroupBoxOption m_SelectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_SelectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGroupBoxOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_SelectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00071310 File Offset: 0x0006F510
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000AF2C File Offset: 0x0000912C
		public unsafe IGroupBox m_GroupBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_GroupBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGroupBox>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultGroupManager.NativeFieldInfoPtr_m_GroupBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00071340 File Offset: 0x0006F540
		public IGroupBoxOption GetSelectedOption()
		{
			return this.m_SelectedOption;
		}

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupOptions;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedOption;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupBox;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IGroupBox_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOption_Public_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
