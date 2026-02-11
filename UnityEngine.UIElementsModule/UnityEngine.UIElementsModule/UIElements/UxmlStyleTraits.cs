using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EF RID: 495
	public class UxmlStyleTraits : UxmlTraits
	{
		// Token: 0x0600273B RID: 10043 RVA: 0x000AD428 File Offset: 0x000AB628
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlStyleTraits()
		{
			Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlStyleTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr);
			UxmlStyleTraits.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr, "m_Name");
			UxmlStyleTraits.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr, "m_Path");
			UxmlStyleTraits.NativeFieldInfoPtr_m_Src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr, "m_Src");
			UxmlStyleTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr, 100669216);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343087, XrefRangeEnd = 343110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlStyleTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlStyleTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStyleTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0000FE88 File Offset: 0x0000E088
		public UxmlStyleTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		// (set) Token: 0x0600273F RID: 10047 RVA: 0x0000FE91 File Offset: 0x0000E091
		public unsafe UxmlStringAttributeDescription m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000AD514 File Offset: 0x000AB714
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		public unsafe UxmlStringAttributeDescription m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000AD544 File Offset: 0x000AB744
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x0000FECF File Offset: 0x0000E0CF
		public unsafe UxmlStringAttributeDescription m_Src
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Src);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlStyleTraits.NativeFieldInfoPtr_m_Src), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x0000FEEE File Offset: 0x0000E0EE
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeFieldInfoPtr_m_Src;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004FC RID: 1276
		public sealed class <get_uxmlChildElementsDescription>d__4
		{
		}
	}
}
