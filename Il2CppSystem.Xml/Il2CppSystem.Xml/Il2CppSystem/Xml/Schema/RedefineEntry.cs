using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017F RID: 383
	public class RedefineEntry : Object
	{
		// Token: 0x06001E4D RID: 7757 RVA: 0x00095A34 File Offset: 0x00093C34
		// Note: this type is marked as 'beforefieldinit'.
		static RedefineEntry()
		{
			Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RedefineEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr);
			RedefineEntry.NativeFieldInfoPtr_redefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, "redefine");
			RedefineEntry.NativeFieldInfoPtr_schemaToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, "schemaToUpdate");
			RedefineEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr, 100667842);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00095AA0 File Offset: 0x00093CA0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedefineEntry(XmlSchemaRedefine external, XmlSchema schema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedefineEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(external);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedefineEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0000C780 File Offset: 0x0000A980
		public RedefineEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00095B00 File Offset: 0x00093D00
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000C789 File Offset: 0x0000A989
		public unsafe XmlSchemaRedefine redefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_redefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaRedefine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_redefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00095B30 File Offset: 0x00093D30
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		public unsafe XmlSchema schemaToUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_schemaToUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedefineEntry.NativeFieldInfoPtr_schemaToUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_redefine;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_schemaToUpdate;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaRedefine_XmlSchema_0;
	}
}
