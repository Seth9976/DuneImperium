using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000072 RID: 114
	[Serializable]
	public class ValueTupleSource : Object
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTupleSource()
		{
			Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "ValueTupleSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr);
			ValueTupleSource.NativeFieldInfoPtr_m_Formatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr, "m_Formatter");
			ValueTupleSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr, 100664299);
			ValueTupleSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr, 100664300);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001D944 File Offset: 0x0001BB44
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTupleSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTupleSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTupleSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001D990 File Offset: 0x0001BB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073078, XrefRangeEnd = 1073129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTupleSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000040C7 File Offset: 0x000022C7
		public ValueTupleSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x000040D0 File Offset: 0x000022D0
		public unsafe SmartFormatter m_Formatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTupleSource.NativeFieldInfoPtr_m_Formatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTupleSource.NativeFieldInfoPtr_m_Formatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_m_Formatter;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;
	}
}
