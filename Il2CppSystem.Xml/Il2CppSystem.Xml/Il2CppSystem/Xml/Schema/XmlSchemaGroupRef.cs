using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C5 RID: 453
	public class XmlSchemaGroupRef : XmlSchemaParticle
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x000B3B6C File Offset: 0x000B1D6C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaGroupRef()
		{
			Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaGroupRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr);
			XmlSchemaGroupRef.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "refName");
			XmlSchemaGroupRef.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "particle");
			XmlSchemaGroupRef.NativeFieldInfoPtr_refined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, "refined");
			XmlSchemaGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668835);
			XmlSchemaGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668836);
			XmlSchemaGroupRef.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaGroupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668837);
			XmlSchemaGroupRef.NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668838);
			XmlSchemaGroupRef.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668839);
			XmlSchemaGroupRef.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668840);
			XmlSchemaGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr, 100668841);
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000B3C64 File Offset: 0x000B1E64
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x000B3CA4 File Offset: 0x000B1EA4
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412340, RefRangeEnd = 412341, XrefRangeStart = 412331, XrefRangeEnd = 412340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000B3CE8 File Offset: 0x000B1EE8
		public unsafe XmlSchemaGroupBase Particle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaGroupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroupBase>(intPtr3) : null;
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000B3D28 File Offset: 0x000B1F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticle(XmlSchemaGroupBase value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x000B3D6C File Offset: 0x000B1F6C
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x000B3DAC File Offset: 0x000B1FAC
		public unsafe XmlSchemaGroup Redefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412350, RefRangeEnd = 412351, XrefRangeStart = 412341, XrefRangeEnd = 412350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaGroupRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaGroupRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0001043A File Offset: 0x0000E63A
		public XmlSchemaGroupRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x000B3E2C File Offset: 0x000B202C
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00010443 File Offset: 0x0000E643
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000B3E5C File Offset: 0x000B205C
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00010462 File Offset: 0x0000E662
		public unsafe XmlSchemaGroupBase particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroupBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x000B3E8C File Offset: 0x000B208C
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00010481 File Offset: 0x0000E681
		public unsafe XmlSchemaGroup refined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refined);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaGroupRef.NativeFieldInfoPtr_refined), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeFieldInfoPtr_refined;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaGroupBase_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_SetParticle_Internal_Void_XmlSchemaGroupBase_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaGroup_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaGroup_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
