using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200000F RID: 15
	public sealed class NamespaceCache : ValueType
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00005E0C File Offset: 0x0000400C
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceCache()
		{
			Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "NamespaceCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr);
			NamespaceCache.NativeFieldInfoPtr__ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, "_ns");
			NamespaceCache.NativeFieldInfoPtr__namespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, "_namespaceName");
			NamespaceCache.NativeMethodInfoPtr_Get_Public_XNamespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, 100663449);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005E78 File Offset: 0x00004078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238007, XrefRangeEnd = 1238010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XNamespace Get(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceCache.NativeMethodInfoPtr_Get_Public_XNamespace_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002343 File Offset: 0x00000543
		public NamespaceCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000234C File Offset: 0x0000054C
		public NamespaceCache()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr))
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005ED0 File Offset: 0x000040D0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000235E File Offset: 0x0000055E
		public unsafe XNamespace _ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceCache.NativeFieldInfoPtr__ns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceCache.NativeFieldInfoPtr__ns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005F00 File Offset: 0x00004100
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000237D File Offset: 0x0000057D
		public unsafe string _namespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceCache.NativeFieldInfoPtr__namespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceCache.NativeFieldInfoPtr__namespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr__ns;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr__namespaceName;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_XNamespace_String_0;
	}
}
