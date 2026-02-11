using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x02000228 RID: 552
	public class BatchRendererGroup : Object
	{
		// Token: 0x060024CF RID: 9423 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererGroup()
		{
			Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
			BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_GroupHandle");
			BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_PerformCulling");
			BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668069);
			BatchRendererGroup.SetPickingMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetPickingMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetPickingMaterial");
			BatchRendererGroup.SetErrorMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetErrorMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetErrorMaterial");
			BatchRendererGroup.SetLoadingMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetLoadingMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetLoadingMaterial");
			BatchRendererGroup.SetEnabledViewTypesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetEnabledViewTypesDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetEnabledViewTypes");
			BatchRendererGroup.GetBufferTargetDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBufferTargetDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBufferTarget");
			BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferMaxWindowSize");
			BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferOffsetAlignment");
			BatchRendererGroup.CreateDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.CreateDelegate>("UnityEngine.Rendering.BatchRendererGroup::Create");
			BatchRendererGroup.DestroyDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.DestroyDelegate>("UnityEngine.Rendering.BatchRendererGroup::Destroy");
			BatchRendererGroup.AddDrawCommandBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.AddDrawCommandBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::AddDrawCommandBatch_Injected");
			BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RemoveDrawCommandBatch_Injected");
			BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetDrawCommandBatchBuffer_Injected");
			BatchRendererGroup.RegisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_Injected");
			BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_InstanceID_Injected");
			BatchRendererGroup.UnregisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMaterial_Injected");
			BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMaterial_Injected");
			BatchRendererGroup.RegisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_Injected");
			BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_InstanceID_Injected");
			BatchRendererGroup.UnregisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMesh_Injected");
			BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMesh_Injected");
			BatchRendererGroup.SetGlobalBounds_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetGlobalBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetGlobalBounds_Injected");
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0009E08C File Offset: 0x0009C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683263, XrefRangeEnd = 683275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lodParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0000E886 File Offset: 0x0000CA86
		public BatchRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000E88F File Offset: 0x0000CA8F
		public unsafe IntPtr m_GroupHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0009E114 File Offset: 0x0009C314
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0000E8AA File Offset: 0x0000CAAA
		public unsafe BatchRendererGroup.OnPerformCulling m_PerformCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		public void Dispose()
		{
			BatchRendererGroup.Destroy(this.m_GroupHandle);
			this.m_GroupHandle = IntPtr.Zero;
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0009E144 File Offset: 0x0009C344
		public BatchID AddDrawCommandBatch(IntPtr values, int count, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize)
		{
			BatchID batchID;
			this.AddDrawCommandBatch_Injected(values, count, ref buffer, bufferOffset, windowSize, out batchID);
			return batchID;
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x0000E8E3 File Offset: 0x0000CAE3
		public void RemoveDrawCommandBatch(BatchID batchID)
		{
			this.RemoveDrawCommandBatch_Injected(ref batchID);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0000E8ED File Offset: 0x0000CAED
		public void RemoveBatch(BatchID batchID)
		{
			this.RemoveDrawCommandBatch(batchID);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		public void SetDrawCommandBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
		{
			this.SetDrawCommandBatchBuffer_Injected(ref batchID, ref buffer);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0000E904 File Offset: 0x0000CB04
		public void SetBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
		{
			this.SetDrawCommandBatchBuffer(batchID, buffer);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0009E164 File Offset: 0x0009C364
		public BatchMaterialID RegisterMaterial(Material material)
		{
			BatchMaterialID batchMaterialID;
			this.RegisterMaterial_Injected(material, out batchMaterialID);
			return batchMaterialID;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0000E910 File Offset: 0x0000CB10
		public BatchMaterialID RegisterMaterial(int materialInstanceID)
		{
			return this.RegisterMaterial_InstanceID(materialInstanceID);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0009E17C File Offset: 0x0009C37C
		public BatchMaterialID RegisterMaterial_InstanceID(int materialInstanceID)
		{
			BatchMaterialID batchMaterialID;
			this.RegisterMaterial_InstanceID_Injected(materialInstanceID, out batchMaterialID);
			return batchMaterialID;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0000E919 File Offset: 0x0000CB19
		public void UnregisterMaterial(BatchMaterialID material)
		{
			this.UnregisterMaterial_Injected(ref material);
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0000E923 File Offset: 0x0000CB23
		public Material GetRegisteredMaterial(BatchMaterialID material)
		{
			return this.GetRegisteredMaterial_Injected(ref material);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0009E194 File Offset: 0x0009C394
		public BatchMeshID RegisterMesh(Mesh mesh)
		{
			BatchMeshID batchMeshID;
			this.RegisterMesh_Injected(mesh, out batchMeshID);
			return batchMeshID;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0000E92D File Offset: 0x0000CB2D
		public BatchMeshID RegisterMesh(int meshInstanceID)
		{
			return this.RegisterMesh_InstanceID(meshInstanceID);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0009E1AC File Offset: 0x0009C3AC
		public BatchMeshID RegisterMesh_InstanceID(int meshInstanceID)
		{
			BatchMeshID batchMeshID;
			this.RegisterMesh_InstanceID_Injected(meshInstanceID, out batchMeshID);
			return batchMeshID;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0000E936 File Offset: 0x0000CB36
		public void UnregisterMesh(BatchMeshID mesh)
		{
			this.UnregisterMesh_Injected(ref mesh);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0000E940 File Offset: 0x0000CB40
		public Mesh GetRegisteredMesh(BatchMeshID mesh)
		{
			return this.GetRegisteredMesh_Injected(ref mesh);
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0000E94A File Offset: 0x0000CB4A
		public void SetGlobalBounds(Bounds bounds)
		{
			this.SetGlobalBounds_Injected(ref bounds);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x0000E954 File Offset: 0x0000CB54
		public void SetPickingMaterial(Material material)
		{
			BatchRendererGroup.SetPickingMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0000E96C File Offset: 0x0000CB6C
		public void SetErrorMaterial(Material material)
		{
			BatchRendererGroup.SetErrorMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0000E984 File Offset: 0x0000CB84
		public void SetLoadingMaterial(Material material)
		{
			BatchRendererGroup.SetLoadingMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0000E99C File Offset: 0x0000CB9C
		public void SetEnabledViewTypes(Il2CppStructArray<BatchCullingViewType> viewTypes)
		{
			BatchRendererGroup.SetEnabledViewTypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(viewTypes));
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public static BatchBufferTarget GetBufferTarget()
		{
			return BatchRendererGroup.GetBufferTargetDelegateField();
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public static BatchBufferTarget BufferTarget
		{
			get
			{
				return BatchRendererGroup.GetBufferTarget();
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0000E9C7 File Offset: 0x0000CBC7
		public static int GetConstantBufferMaxWindowSize()
		{
			return BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField();
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0000E9D3 File Offset: 0x0000CBD3
		public static int GetConstantBufferOffsetAlignment()
		{
			return BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0000E9DF File Offset: 0x0000CBDF
		public unsafe static IntPtr Create(BatchRendererGroup group, void* userContext)
		{
			return BatchRendererGroup.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(group), userContext);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0000E9F2 File Offset: 0x0000CBF2
		public static void Destroy(IntPtr groupHandle)
		{
			BatchRendererGroup.DestroyDelegateField(groupHandle);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0000E9FF File Offset: 0x0000CBFF
		public void AddDrawCommandBatch_Injected(IntPtr values, int count, ref GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, out BatchID ret)
		{
			BatchRendererGroup.AddDrawCommandBatch_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), values, count, ref buffer, bufferOffset, windowSize, out ret);
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0000EA1A File Offset: 0x0000CC1A
		public void RemoveDrawCommandBatch_Injected(ref BatchID batchID)
		{
			BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref batchID);
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x0000EA2D File Offset: 0x0000CC2D
		public void SetDrawCommandBatchBuffer_Injected(ref BatchID batchID, ref GraphicsBufferHandle buffer)
		{
			BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref batchID, ref buffer);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0000EA41 File Offset: 0x0000CC41
		public void RegisterMaterial_Injected(Material material, out BatchMaterialID ret)
		{
			BatchRendererGroup.RegisterMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material), out ret);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0000EA5A File Offset: 0x0000CC5A
		public void RegisterMaterial_InstanceID_Injected(int materialInstanceID, out BatchMaterialID ret)
		{
			BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), materialInstanceID, out ret);
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x0000EA6E File Offset: 0x0000CC6E
		public void UnregisterMaterial_Injected(ref BatchMaterialID material)
		{
			BatchRendererGroup.UnregisterMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref material);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x0009E1C4 File Offset: 0x0009C3C4
		public Material GetRegisteredMaterial_Injected(ref BatchMaterialID material)
		{
			IntPtr intPtr = BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref material);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0000EA81 File Offset: 0x0000CC81
		public void RegisterMesh_Injected(Mesh mesh, out BatchMeshID ret)
		{
			BatchRendererGroup.RegisterMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), out ret);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0000EA9A File Offset: 0x0000CC9A
		public void RegisterMesh_InstanceID_Injected(int meshInstanceID, out BatchMeshID ret)
		{
			BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), meshInstanceID, out ret);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x0000EAAE File Offset: 0x0000CCAE
		public void UnregisterMesh_Injected(ref BatchMeshID mesh)
		{
			BatchRendererGroup.UnregisterMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref mesh);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0009E1F4 File Offset: 0x0009C3F4
		public Mesh GetRegisteredMesh_Injected(ref BatchMeshID mesh)
		{
			IntPtr intPtr = BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref mesh);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0000EAC1 File Offset: 0x0000CCC1
		public void SetGlobalBounds_Injected(ref Bounds bounds)
		{
			BatchRendererGroup.SetGlobalBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bounds);
		}

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupHandle;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformCulling;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0;

		// Token: 0x0400208B RID: 8331
		private static readonly BatchRendererGroup.SetPickingMaterialDelegate SetPickingMaterialDelegateField;

		// Token: 0x0400208C RID: 8332
		private static readonly BatchRendererGroup.SetErrorMaterialDelegate SetErrorMaterialDelegateField;

		// Token: 0x0400208D RID: 8333
		private static readonly BatchRendererGroup.SetLoadingMaterialDelegate SetLoadingMaterialDelegateField;

		// Token: 0x0400208E RID: 8334
		private static readonly BatchRendererGroup.SetEnabledViewTypesDelegate SetEnabledViewTypesDelegateField;

		// Token: 0x0400208F RID: 8335
		private static readonly BatchRendererGroup.GetBufferTargetDelegate GetBufferTargetDelegateField;

		// Token: 0x04002090 RID: 8336
		private static readonly BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate GetConstantBufferMaxWindowSizeDelegateField;

		// Token: 0x04002091 RID: 8337
		private static readonly BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate GetConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x04002092 RID: 8338
		private static readonly BatchRendererGroup.CreateDelegate CreateDelegateField;

		// Token: 0x04002093 RID: 8339
		private static readonly BatchRendererGroup.DestroyDelegate DestroyDelegateField;

		// Token: 0x04002094 RID: 8340
		private static readonly BatchRendererGroup.AddDrawCommandBatch_InjectedDelegate AddDrawCommandBatch_InjectedDelegateField;

		// Token: 0x04002095 RID: 8341
		private static readonly BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate RemoveDrawCommandBatch_InjectedDelegateField;

		// Token: 0x04002096 RID: 8342
		private static readonly BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegate SetDrawCommandBatchBuffer_InjectedDelegateField;

		// Token: 0x04002097 RID: 8343
		private static readonly BatchRendererGroup.RegisterMaterial_InjectedDelegate RegisterMaterial_InjectedDelegateField;

		// Token: 0x04002098 RID: 8344
		private static readonly BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegate RegisterMaterial_InstanceID_InjectedDelegateField;

		// Token: 0x04002099 RID: 8345
		private static readonly BatchRendererGroup.UnregisterMaterial_InjectedDelegate UnregisterMaterial_InjectedDelegateField;

		// Token: 0x0400209A RID: 8346
		private static readonly BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate GetRegisteredMaterial_InjectedDelegateField;

		// Token: 0x0400209B RID: 8347
		private static readonly BatchRendererGroup.RegisterMesh_InjectedDelegate RegisterMesh_InjectedDelegateField;

		// Token: 0x0400209C RID: 8348
		private static readonly BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegate RegisterMesh_InstanceID_InjectedDelegateField;

		// Token: 0x0400209D RID: 8349
		private static readonly BatchRendererGroup.UnregisterMesh_InjectedDelegate UnregisterMesh_InjectedDelegateField;

		// Token: 0x0400209E RID: 8350
		private static readonly BatchRendererGroup.GetRegisteredMesh_InjectedDelegate GetRegisteredMesh_InjectedDelegateField;

		// Token: 0x0400209F RID: 8351
		private static readonly BatchRendererGroup.SetGlobalBounds_InjectedDelegate SetGlobalBounds_InjectedDelegateField;

		// Token: 0x020009BB RID: 2491
		public sealed class OnPerformCulling : MulticastDelegate
		{
			// Token: 0x06003C8F RID: 15503 RVA: 0x000164D0 File Offset: 0x000146D0
			// Note: this type is marked as 'beforefieldinit'.
			static OnPerformCulling()
			{
				Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnPerformCulling");
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100668070);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100668071);
			}

			// Token: 0x06003C90 RID: 15504 RVA: 0x000BEB60 File Offset: 0x000BCD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683254, XrefRangeEnd = 683263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPerformCulling(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C91 RID: 15505 RVA: 0x000BEBBC File Offset: 0x000BCDBC
			[CallerCount(0)]
			public unsafe Unity.Jobs.JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererGroup);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingContext));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingOutput));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003C92 RID: 15506 RVA: 0x0001650E File Offset: 0x0001470E
			public OnPerformCulling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003C93 RID: 15507 RVA: 0x00016517 File Offset: 0x00014717
			public static implicit operator BatchRendererGroup.OnPerformCulling(Func<BatchRendererGroup, BatchCullingContext, BatchCullingOutput, IntPtr, Unity.Jobs.JobHandle> A_0)
			{
				return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnPerformCulling>(A_0);
			}

			// Token: 0x06003C94 RID: 15508 RVA: 0x0001651F File Offset: 0x0001471F
			public static BatchRendererGroup.OnPerformCulling operator +(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BatchRendererGroup.OnPerformCulling>();
			}

			// Token: 0x06003C95 RID: 15509 RVA: 0x0001652D File Offset: 0x0001472D
			public static BatchRendererGroup.OnPerformCulling operator -(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<BatchRendererGroup.OnPerformCulling>();
				}
				return delegate2;
			}

			// Token: 0x04002D20 RID: 11552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002D21 RID: 11553
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0;
		}

		// Token: 0x020009BC RID: 2492
		// (Invoke) Token: 0x06003C97 RID: 15511
		private delegate void SetPickingMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x020009BD RID: 2493
		// (Invoke) Token: 0x06003C99 RID: 15513
		private delegate void SetErrorMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x020009BE RID: 2494
		// (Invoke) Token: 0x06003C9B RID: 15515
		private delegate void SetLoadingMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x020009BF RID: 2495
		// (Invoke) Token: 0x06003C9D RID: 15517
		private delegate void SetEnabledViewTypesDelegate(IntPtr @this, IntPtr viewTypes);

		// Token: 0x020009C0 RID: 2496
		// (Invoke) Token: 0x06003C9F RID: 15519
		private delegate BatchBufferTarget GetBufferTargetDelegate();

		// Token: 0x020009C1 RID: 2497
		// (Invoke) Token: 0x06003CA1 RID: 15521
		private delegate int GetConstantBufferMaxWindowSizeDelegate();

		// Token: 0x020009C2 RID: 2498
		// (Invoke) Token: 0x06003CA3 RID: 15523
		private delegate int GetConstantBufferOffsetAlignmentDelegate();

		// Token: 0x020009C3 RID: 2499
		// (Invoke) Token: 0x06003CA5 RID: 15525
		private delegate IntPtr CreateDelegate(IntPtr group, IntPtr userContext);

		// Token: 0x020009C4 RID: 2500
		// (Invoke) Token: 0x06003CA7 RID: 15527
		private delegate void DestroyDelegate(IntPtr groupHandle);

		// Token: 0x020009C5 RID: 2501
		// (Invoke) Token: 0x06003CA9 RID: 15529
		private delegate void AddDrawCommandBatch_InjectedDelegate(IntPtr @this, IntPtr values, int count, IntPtr buffer, uint bufferOffset, uint windowSize, [Out] IntPtr ret);

		// Token: 0x020009C6 RID: 2502
		// (Invoke) Token: 0x06003CAB RID: 15531
		private delegate void RemoveDrawCommandBatch_InjectedDelegate(IntPtr @this, IntPtr batchID);

		// Token: 0x020009C7 RID: 2503
		// (Invoke) Token: 0x06003CAD RID: 15533
		private delegate void SetDrawCommandBatchBuffer_InjectedDelegate(IntPtr @this, IntPtr batchID, IntPtr buffer);

		// Token: 0x020009C8 RID: 2504
		// (Invoke) Token: 0x06003CAF RID: 15535
		private delegate void RegisterMaterial_InjectedDelegate(IntPtr @this, IntPtr material, [Out] IntPtr ret);

		// Token: 0x020009C9 RID: 2505
		// (Invoke) Token: 0x06003CB1 RID: 15537
		private delegate void RegisterMaterial_InstanceID_InjectedDelegate(IntPtr @this, int materialInstanceID, [Out] IntPtr ret);

		// Token: 0x020009CA RID: 2506
		// (Invoke) Token: 0x06003CB3 RID: 15539
		private delegate void UnregisterMaterial_InjectedDelegate(IntPtr @this, IntPtr material);

		// Token: 0x020009CB RID: 2507
		// (Invoke) Token: 0x06003CB5 RID: 15541
		private delegate IntPtr GetRegisteredMaterial_InjectedDelegate(IntPtr @this, IntPtr material);

		// Token: 0x020009CC RID: 2508
		// (Invoke) Token: 0x06003CB7 RID: 15543
		private delegate void RegisterMesh_InjectedDelegate(IntPtr @this, IntPtr mesh, [Out] IntPtr ret);

		// Token: 0x020009CD RID: 2509
		// (Invoke) Token: 0x06003CB9 RID: 15545
		private delegate void RegisterMesh_InstanceID_InjectedDelegate(IntPtr @this, int meshInstanceID, [Out] IntPtr ret);

		// Token: 0x020009CE RID: 2510
		// (Invoke) Token: 0x06003CBB RID: 15547
		private delegate void UnregisterMesh_InjectedDelegate(IntPtr @this, IntPtr mesh);

		// Token: 0x020009CF RID: 2511
		// (Invoke) Token: 0x06003CBD RID: 15549
		private delegate IntPtr GetRegisteredMesh_InjectedDelegate(IntPtr @this, IntPtr mesh);

		// Token: 0x020009D0 RID: 2512
		// (Invoke) Token: 0x06003CBF RID: 15551
		private delegate void SetGlobalBounds_InjectedDelegate(IntPtr @this, IntPtr bounds);
	}
}
