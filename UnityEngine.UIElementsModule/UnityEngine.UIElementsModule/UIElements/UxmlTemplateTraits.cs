using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F1 RID: 497
	public class UxmlTemplateTraits : UxmlTraits
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x000AD72C File Offset: 0x000AB92C
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlTemplateTraits()
		{
			Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlTemplateTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr);
			UxmlTemplateTraits.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr, "m_Name");
			UxmlTemplateTraits.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr, "m_Path");
			UxmlTemplateTraits.NativeFieldInfoPtr_m_Src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr, "m_Src");
			UxmlTemplateTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr, 100669221);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000AD7AC File Offset: 0x000AB9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343118, XrefRangeEnd = 343141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlTemplateTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlTemplateTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTemplateTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0000FF40 File Offset: 0x0000E140
		public UxmlTemplateTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AD7E8 File Offset: 0x000AB9E8
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x0000FF49 File Offset: 0x0000E149
		public unsafe UxmlStringAttributeDescription m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000AD818 File Offset: 0x000ABA18
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x0000FF68 File Offset: 0x0000E168
		public unsafe UxmlStringAttributeDescription m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000AD848 File Offset: 0x000ABA48
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x0000FF87 File Offset: 0x0000E187
		public unsafe UxmlStringAttributeDescription m_Src
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Src);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlTemplateTraits.NativeFieldInfoPtr_m_Src), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_m_Src;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004FD RID: 1277
		public sealed class <get_uxmlChildElementsDescription>d__4
		{
		}
	}
}
