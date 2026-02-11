using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.Linq;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000074 RID: 116
	[Serializable]
	public class XmlSource : Object
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x0001DB5C File Offset: 0x0001BD5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSource()
		{
			Il2CppClassPointerStore<XmlSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "XmlSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSource>.NativeClassPtr);
			XmlSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSource>.NativeClassPtr, 100664304);
			XmlSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSource>.NativeClassPtr, 100664305);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001DBB4 File Offset: 0x0001BDB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073162, RefRangeEnd = 1073163, XrefRangeStart = 1073154, XrefRangeEnd = 1073162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001DC00 File Offset: 0x0001BE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073163, XrefRangeEnd = 1073194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000040F8 File Offset: 0x000022F8
		public XmlSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;

		// Token: 0x0200014C RID: 332
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.XmlSource+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06000EAD RID: 3757 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSource>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr);
				XmlSource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr, "selector");
				XmlSource.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr, 100664306);
				XmlSource.__c__DisplayClass1_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr, 100664307);
			}

			// Token: 0x06000EAE RID: 3758 RVA: 0x0003F608 File Offset: 0x0003D808
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSource.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSource.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EAF RID: 3759 RVA: 0x0003F644 File Offset: 0x0003D844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073152, XrefRangeEnd = 1073154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryEvaluateSelector_b__0(XElement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSource.__c__DisplayClass1_0.NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EB0 RID: 3760 RVA: 0x000082B8 File Offset: 0x000064B8
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0003F694 File Offset: 0x0003D894
			// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x000082C1 File Offset: 0x000064C1
			public unsafe string selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSource.__c__DisplayClass1_0.NativeFieldInfoPtr_selector), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000A15 RID: 2581
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000A16 RID: 2582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A17 RID: 2583
			private static readonly IntPtr NativeMethodInfoPtr__TryEvaluateSelector_b__0_Internal_Boolean_XElement_0;
		}
	}
}
