using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000246 RID: 582
	public class DetachedAllocator : Object
	{
		// Token: 0x06002AF1 RID: 10993 RVA: 0x000BA91C File Offset: 0x000B8B1C
		// Note: this type is marked as 'beforefieldinit'.
		static DetachedAllocator()
		{
			Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "DetachedAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr);
			DetachedAllocator.NativeFieldInfoPtr_m_VertsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, "m_VertsPool");
			DetachedAllocator.NativeFieldInfoPtr_m_IndexPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, "m_IndexPool");
			DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, "m_MeshWriteDataPool");
			DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, "m_MeshWriteDataCount");
			DetachedAllocator.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, "m_Disposed");
			DetachedAllocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, 100669721);
			DetachedAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, 100669722);
			DetachedAllocator.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr, 100669723);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000BA9EC File Offset: 0x000B8BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348291, RefRangeEnd = 348292, XrefRangeStart = 348269, XrefRangeEnd = 348291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetachedAllocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachedAllocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachedAllocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000BAA28 File Offset: 0x000B8C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348303, RefRangeEnd = 348305, XrefRangeStart = 348292, XrefRangeEnd = 348303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachedAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000BAA5C File Offset: 0x000B8C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348305, XrefRangeEnd = 348311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachedAllocator.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00011430 File Offset: 0x0000F630
		public DetachedAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000BAA9C File Offset: 0x000B8C9C
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x00011439 File Offset: 0x0000F639
		public unsafe TempAllocator<Vertex> m_VertsPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_VertsPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_VertsPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000BAACC File Offset: 0x000B8CCC
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00011458 File Offset: 0x0000F658
		public unsafe TempAllocator<ushort> m_IndexPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_IndexPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TempAllocator<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_IndexPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000BAAFC File Offset: 0x000B8CFC
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x00011477 File Offset: 0x0000F677
		public unsafe List<MeshWriteData> m_MeshWriteDataPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshWriteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x000BAB2C File Offset: 0x000B8D2C
		// (set) Token: 0x06002AFD RID: 11005 RVA: 0x00011496 File Offset: 0x0000F696
		public unsafe int m_MeshWriteDataCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_MeshWriteDataCount)) = value;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000BAB54 File Offset: 0x000B8D54
		// (set) Token: 0x06002AFF RID: 11007 RVA: 0x000114B1 File Offset: 0x0000F6B1
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetachedAllocator.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x000114CC File Offset: 0x0000F6CC
		public List<MeshWriteData> meshes
		{
			get
			{
				return this.m_MeshWriteDataPool.GetRange(0, this.m_MeshWriteDataCount);
			}
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000BAB7C File Offset: 0x000B8D7C
		public MeshWriteData Alloc(int vertexCount, int indexCount)
		{
			bool flag = this.m_MeshWriteDataCount < this.m_MeshWriteDataPool.Count;
			MeshWriteData meshWriteData;
			if (flag)
			{
				meshWriteData = this.m_MeshWriteDataPool[this.m_MeshWriteDataCount];
			}
			else
			{
				meshWriteData = new MeshWriteData();
				this.m_MeshWriteDataPool.Add(meshWriteData);
			}
			this.m_MeshWriteDataCount++;
			bool flag2 = vertexCount == 0 || indexCount == 0;
			MeshWriteData meshWriteData2;
			if (flag2)
			{
				meshWriteData.Reset(null, null);
				meshWriteData2 = meshWriteData;
			}
			else
			{
				meshWriteData.Reset(this.m_VertsPool.Alloc(vertexCount), this.m_IndexPool.Alloc(indexCount));
				meshWriteData2 = meshWriteData;
			}
			return meshWriteData2;
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public void Clear()
		{
			this.m_VertsPool.Reset();
			this.m_IndexPool.Reset();
			this.m_MeshWriteDataCount = 0;
		}

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_m_VertsPool;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexPool;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshWriteDataPool;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshWriteDataCount;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
