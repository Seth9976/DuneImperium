using System;
using Canis.attributes;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.match.data
{
	// Token: 0x02000278 RID: 632
	public class OpponentActivityData : DataComponent
	{
		// Token: 0x06001D8E RID: 7566 RVA: 0x0007FC80 File Offset: 0x0007DE80
		// Note: this type is marked as 'beforefieldinit'.
		static OpponentActivityData()
		{
			Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "OpponentActivityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr);
			OpponentActivityData.NativeFieldInfoPtr_nonPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr, "nonPromptText");
			OpponentActivityData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr, 100668139);
			OpponentActivityData.NativeMethodInfoPtr_get_ActivityText_Public_Virtual_New_get_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr, 100668140);
			OpponentActivityData.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr, 100668141);
			OpponentActivityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr, 100668142);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0007FD14 File Offset: 0x0007DF14
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpponentActivityData(IAttribute<LocalizableText> nonPromptText)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentActivityData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonPromptText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentActivityData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0007FD60 File Offset: 0x0007DF60
		public unsafe virtual LocalizableText ActivityText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537059, XrefRangeEnd = 537066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentActivityData.NativeMethodInfoPtr_get_ActivityText_Public_Virtual_New_get_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0007FDAC File Offset: 0x0007DFAC
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537066, XrefRangeEnd = 537070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentActivityData.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0007FDF4 File Offset: 0x0007DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537070, XrefRangeEnd = 537075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentActivityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		public OpponentActivityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0007FE38 File Offset: 0x0007E038
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000FAD1 File Offset: 0x0000DCD1
		public unsafe IAttribute<LocalizableText> nonPromptText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentActivityData.NativeFieldInfoPtr_nonPromptText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentActivityData.NativeFieldInfoPtr_nonPromptText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeFieldInfoPtr_nonPromptText;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivityText_Public_Virtual_New_get_LocalizableText_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
