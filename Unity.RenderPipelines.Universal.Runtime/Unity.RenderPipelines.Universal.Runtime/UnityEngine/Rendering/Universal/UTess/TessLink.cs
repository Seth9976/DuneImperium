using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013F RID: 319
	public sealed class TessLink : ValueType
	{
		// Token: 0x06001AB0 RID: 6832 RVA: 0x0006F9FC File Offset: 0x0006DBFC
		// Note: this type is marked as 'beforefieldinit'.
		static TessLink()
		{
			Il2CppClassPointerStore<TessLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "TessLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessLink>.NativeClassPtr);
			TessLink.NativeFieldInfoPtr_roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessLink>.NativeClassPtr, "roots");
			TessLink.NativeFieldInfoPtr_ranks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessLink>.NativeClassPtr, "ranks");
			TessLink.NativeMethodInfoPtr_CreateLink_Internal_Static_TessLink_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessLink>.NativeClassPtr, 100666421);
			TessLink.NativeMethodInfoPtr_DestroyLink_Internal_Static_Void_TessLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessLink>.NativeClassPtr, 100666422);
			TessLink.NativeMethodInfoPtr_Find_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessLink>.NativeClassPtr, 100666423);
			TessLink.NativeMethodInfoPtr_Link_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessLink>.NativeClassPtr, 100666424);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0006FAA4 File Offset: 0x0006DCA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629884, RefRangeEnd = 629885, XrefRangeStart = 629879, XrefRangeEnd = 629884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TessLink CreateLink(int count, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessLink.NativeMethodInfoPtr_CreateLink_Internal_Static_TessLink_Int32_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TessLink(intPtr);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0006FAEC File Offset: 0x0006DCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629890, RefRangeEnd = 629891, XrefRangeStart = 629885, XrefRangeEnd = 629890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyLink(TessLink link)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(link));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessLink.NativeMethodInfoPtr_DestroyLink_Internal_Static_Void_TessLink_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0006FB28 File Offset: 0x0006DD28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629891, RefRangeEnd = 629894, XrefRangeStart = 629891, XrefRangeEnd = 629891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Find(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessLink.NativeMethodInfoPtr_Find_Internal_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0006FB78 File Offset: 0x0006DD78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629894, RefRangeEnd = 629895, XrefRangeStart = 629894, XrefRangeEnd = 629894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Link(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessLink.NativeMethodInfoPtr_Link_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0000F284 File Offset: 0x0000D484
		public TessLink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0000F28D File Offset: 0x0000D48D
		public TessLink()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TessLink>.NativeClassPtr))
		{
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0006FBCC File Offset: 0x0006DDCC
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x0000F29F File Offset: 0x0000D49F
		public NativeArray<int> roots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessLink.NativeFieldInfoPtr_roots);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessLink.NativeFieldInfoPtr_roots), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x0000F2CD File Offset: 0x0000D4CD
		public NativeArray<int> ranks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessLink.NativeFieldInfoPtr_ranks);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessLink.NativeFieldInfoPtr_ranks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeFieldInfoPtr_roots;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_ranks;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_CreateLink_Internal_Static_TessLink_Int32_Allocator_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_DestroyLink_Internal_Static_Void_TessLink_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_Find_Internal_Int32_Int32_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_Link_Internal_Void_Int32_Int32_0;
	}
}
