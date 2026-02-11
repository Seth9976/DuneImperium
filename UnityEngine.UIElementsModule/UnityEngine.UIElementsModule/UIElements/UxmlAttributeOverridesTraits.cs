using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F3 RID: 499
	public class UxmlAttributeOverridesTraits : UxmlTraits
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x000ADA30 File Offset: 0x000ABC30
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlAttributeOverridesTraits()
		{
			Il2CppClassPointerStore<UxmlAttributeOverridesTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlAttributeOverridesTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlAttributeOverridesTraits>.NativeClassPtr);
			UxmlAttributeOverridesTraits.NativeFieldInfoPtr_m_ElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeOverridesTraits>.NativeClassPtr, "m_ElementName");
			UxmlAttributeOverridesTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeOverridesTraits>.NativeClassPtr, 100669226);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000ADA88 File Offset: 0x000ABC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343149, XrefRangeEnd = 343158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlAttributeOverridesTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlAttributeOverridesTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeOverridesTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		public UxmlAttributeOverridesTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000ADAC4 File Offset: 0x000ABCC4
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x00010001 File Offset: 0x0000E201
		public unsafe UxmlStringAttributeDescription m_ElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeOverridesTraits.NativeFieldInfoPtr_m_ElementName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeOverridesTraits.NativeFieldInfoPtr_m_ElementName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00010020 File Offset: 0x0000E220
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementName;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C12 RID: 7186
		public const string k_ElementNameAttributeName = "element-name";

		// Token: 0x020004FE RID: 1278
		public sealed class <get_uxmlChildElementsDescription>d__3
		{
		}
	}
}
