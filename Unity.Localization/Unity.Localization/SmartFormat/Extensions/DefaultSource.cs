using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public class DefaultSource : Object
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x0001B3E0 File Offset: 0x000195E0
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultSource()
		{
			Il2CppClassPointerStore<DefaultSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "DefaultSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultSource>.NativeClassPtr);
			DefaultSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSource>.NativeClassPtr, 100664185);
			DefaultSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSource>.NativeClassPtr, 100664186);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001B438 File Offset: 0x00019638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071748, RefRangeEnd = 1071749, XrefRangeStart = 1071740, XrefRangeEnd = 1071748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001B484 File Offset: 0x00019684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071749, XrefRangeEnd = 1071773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003E02 File Offset: 0x00002002
		public DefaultSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;
	}
}
