using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001ED RID: 493
	public class UxmlRootElementTraits : UxmlTraits
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x000AD168 File Offset: 0x000AB368
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlRootElementTraits()
		{
			Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlRootElementTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr);
			UxmlRootElementTraits.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr, "m_Name");
			UxmlRootElementTraits.NativeFieldInfoPtr_m_Class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr, "m_Class");
			UxmlRootElementTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr, 100669211);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000AD1D4 File Offset: 0x000AB3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343063, XrefRangeEnd = 343079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlRootElementTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlRootElementTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlRootElementTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0000FDEF File Offset: 0x0000DFEF
		public UxmlRootElementTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000AD210 File Offset: 0x000AB410
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		public unsafe UxmlStringAttributeDescription m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlRootElementTraits.NativeFieldInfoPtr_m_Name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlRootElementTraits.NativeFieldInfoPtr_m_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000AD240 File Offset: 0x000AB440
		// (set) Token: 0x06002730 RID: 10032 RVA: 0x0000FE17 File Offset: 0x0000E017
		public unsafe UxmlStringAttributeDescription m_Class
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlRootElementTraits.NativeFieldInfoPtr_m_Class);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlRootElementTraits.NativeFieldInfoPtr_m_Class), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x0000FE36 File Offset: 0x0000E036
		public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_m_Class;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004FB RID: 1275
		public sealed class <get_uxmlChildElementsDescription>d__3
		{
		}
	}
}
