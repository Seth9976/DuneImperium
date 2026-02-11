using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000073 RID: 115
	[Serializable]
	public class XElementFormatter : FormatterBase
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x0001DA10 File Offset: 0x0001BC10
		// Note: this type is marked as 'beforefieldinit'.
		static XElementFormatter()
		{
			Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "XElementFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr);
			XElementFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr, 100664301);
			XElementFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr, 100664302);
			XElementFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr, 100664303);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1071545, RefRangeEnd = 1071549, XrefRangeStart = 1071545, XrefRangeEnd = 1071549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XElementFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElementFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElementFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073129, XrefRangeEnd = 1073144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001DB04 File Offset: 0x0001BD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073144, XrefRangeEnd = 1073152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElementFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000040EF File Offset: 0x000022EF
		public XElementFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;
	}
}
