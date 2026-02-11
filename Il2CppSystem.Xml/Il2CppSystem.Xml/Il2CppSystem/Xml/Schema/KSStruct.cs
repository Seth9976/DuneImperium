using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000110 RID: 272
	public class KSStruct : Object
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x0007E354 File Offset: 0x0007C554
		// Note: this type is marked as 'beforefieldinit'.
		static KSStruct()
		{
			Il2CppClassPointerStore<KSStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "KSStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KSStruct>.NativeClassPtr);
			KSStruct.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "depth");
			KSStruct.NativeFieldInfoPtr_ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "ks");
			KSStruct.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, "fields");
			KSStruct.NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KSStruct>.NativeClassPtr, 100667082);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0007E3D4 File Offset: 0x0007C5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391940, XrefRangeEnd = 391946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KSStruct(KeySequence ks, int dim)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KSStruct>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ks);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KSStruct.NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0000A71A File Offset: 0x0000891A
		public KSStruct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x0007E430 File Offset: 0x0007C630
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x0000A723 File Offset: 0x00008923
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x0007E458 File Offset: 0x0007C658
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000A73E File Offset: 0x0000893E
		public unsafe KeySequence ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0007E488 File Offset: 0x0007C688
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000A75D File Offset: 0x0000895D
		public unsafe Il2CppReferenceArray<LocatedActiveAxis> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocatedActiveAxis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KSStruct.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_ks;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeySequence_Int32_0;
	}
}
