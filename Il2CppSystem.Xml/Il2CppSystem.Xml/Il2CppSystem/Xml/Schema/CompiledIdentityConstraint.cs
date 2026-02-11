using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010C RID: 268
	public class CompiledIdentityConstraint : Object
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x0007D864 File Offset: 0x0007BA64
		// Note: this type is marked as 'beforefieldinit'.
		static CompiledIdentityConstraint()
		{
			Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "CompiledIdentityConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr);
			CompiledIdentityConstraint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "name");
			CompiledIdentityConstraint.NativeFieldInfoPtr_role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "role");
			CompiledIdentityConstraint.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "selector");
			CompiledIdentityConstraint.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "fields");
			CompiledIdentityConstraint.NativeFieldInfoPtr_refer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "refer");
			CompiledIdentityConstraint.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "Empty");
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100667066);
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100667067);
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100667068);
			CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100667069);
			CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100667070);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0007D970 File Offset: 0x0007BB70
		public unsafe CompiledIdentityConstraint.ConstraintRole Role
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x0007D9AC File Offset: 0x0007BBAC
		public unsafe Asttree Selector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr3) : null;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0007D9EC File Offset: 0x0007BBEC
		public unsafe Il2CppReferenceArray<Asttree> Fields
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Asttree>>(intPtr3) : null;
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0007DA2C File Offset: 0x0007BC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391820, XrefRangeEnd = 391828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledIdentityConstraint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0007DA68 File Offset: 0x0007BC68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391863, RefRangeEnd = 391865, XrefRangeStart = 391828, XrefRangeEnd = 391863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0000A4E9 File Offset: 0x000086E9
		public CompiledIdentityConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0000A4F2 File Offset: 0x000086F2
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0007DAF8 File Offset: 0x0007BCF8
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000A511 File Offset: 0x00008711
		public unsafe CompiledIdentityConstraint.ConstraintRole role
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_role);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_role)) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0007DB20 File Offset: 0x0007BD20
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000A52C File Offset: 0x0000872C
		public unsafe Asttree selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0007DB50 File Offset: 0x0007BD50
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000A54B File Offset: 0x0000874B
		public unsafe Il2CppReferenceArray<Asttree> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Asttree>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0007DB80 File Offset: 0x0007BD80
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000A56A File Offset: 0x0000876A
		public unsafe XmlQualifiedName refer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_refer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_refer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x0007DBB0 File Offset: 0x0007BDB0
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000A589 File Offset: 0x00008789
		public unsafe static CompiledIdentityConstraint Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompiledIdentityConstraint.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompiledIdentityConstraint.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeFieldInfoPtr_role;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeFieldInfoPtr_refer;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0;

		// Token: 0x02000254 RID: 596
		public enum ConstraintRole
		{
			// Token: 0x04002621 RID: 9761
			Unique,
			// Token: 0x04002622 RID: 9762
			Key,
			// Token: 0x04002623 RID: 9763
			Keyref
		}
	}
}
