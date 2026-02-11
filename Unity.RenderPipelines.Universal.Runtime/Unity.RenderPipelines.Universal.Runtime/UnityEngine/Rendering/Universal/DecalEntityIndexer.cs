using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006E RID: 110
	public class DecalEntityIndexer : Object
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x0003627C File Offset: 0x0003447C
		// Note: this type is marked as 'beforefieldinit'.
		static DecalEntityIndexer()
		{
			Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalEntityIndexer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr);
			DecalEntityIndexer.NativeFieldInfoPtr_m_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "m_Entities");
			DecalEntityIndexer.NativeFieldInfoPtr_m_FreeIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "m_FreeIndices");
			DecalEntityIndexer.NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664580);
			DecalEntityIndexer.NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664581);
			DecalEntityIndexer.NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664582);
			DecalEntityIndexer.NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664583);
			DecalEntityIndexer.NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664584);
			DecalEntityIndexer.NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664585);
			DecalEntityIndexer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664586);
			DecalEntityIndexer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664587);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00036374 File Offset: 0x00034574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 607041, RefRangeEnd = 607044, XrefRangeStart = 607037, XrefRangeEnd = 607041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid(DecalEntity decalEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000363C0 File Offset: 0x000345C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607053, RefRangeEnd = 607054, XrefRangeStart = 607044, XrefRangeEnd = 607053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00036418 File Offset: 0x00034618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607054, XrefRangeEnd = 607063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDecalEntity(DecalEntity decalEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00036458 File Offset: 0x00034658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607063, XrefRangeEnd = 607066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntityIndexer.DecalEntityItem GetItem(DecalEntity decalEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000364A4 File Offset: 0x000346A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607066, XrefRangeEnd = 607072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndex(DecalEntity decalEntity, int newArrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newArrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000364F0 File Offset: 0x000346F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607072, XrefRangeEnd = 607085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemapChunkIndices(List<int> remaper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remaper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00036534 File Offset: 0x00034734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607085, XrefRangeEnd = 607090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00036568 File Offset: 0x00034768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607090, XrefRangeEnd = 607105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntityIndexer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityIndexer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00006237 File Offset: 0x00004437
		public DecalEntityIndexer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000365A4 File Offset: 0x000347A4
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00006240 File Offset: 0x00004440
		public unsafe List<DecalEntityIndexer.DecalEntityItem> m_Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityIndexer.NativeFieldInfoPtr_m_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalEntityIndexer.DecalEntityItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityIndexer.NativeFieldInfoPtr_m_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000365D4 File Offset: 0x000347D4
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0000625F File Offset: 0x0000445F
		public unsafe Queue<int> m_FreeIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityIndexer.NativeFieldInfoPtr_m_FreeIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityIndexer.NativeFieldInfoPtr_m_FreeIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_Entities;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeIndices;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000181 RID: 385
		[StructLayout(2)]
		public struct DecalEntityItem
		{
			// Token: 0x06001CD7 RID: 7383 RVA: 0x00076090 File Offset: 0x00074290
			// Note: this type is marked as 'beforefieldinit'.
			static DecalEntityItem()
			{
				Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "DecalEntityItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr);
				DecalEntityIndexer.DecalEntityItem.NativeFieldInfoPtr_chunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr, "chunkIndex");
				DecalEntityIndexer.DecalEntityItem.NativeFieldInfoPtr_arrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr, "arrayIndex");
				DecalEntityIndexer.DecalEntityItem.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr, "version");
			}

			// Token: 0x06001CD8 RID: 7384 RVA: 0x000107B8 File Offset: 0x0000E9B8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalEntityIndexer.DecalEntityItem>.NativeClassPtr, ref this));
			}

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeFieldInfoPtr_chunkIndex;

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr_arrayIndex;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040014EC RID: 5356
			[FieldOffset(0)]
			public int chunkIndex;

			// Token: 0x040014ED RID: 5357
			[FieldOffset(4)]
			public int arrayIndex;

			// Token: 0x040014EE RID: 5358
			[FieldOffset(8)]
			public int version;
		}
	}
}
