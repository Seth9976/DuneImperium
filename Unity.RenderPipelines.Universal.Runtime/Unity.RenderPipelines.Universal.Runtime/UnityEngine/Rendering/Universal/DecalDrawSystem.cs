using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006D RID: 109
	public class DecalDrawSystem : Object
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x00035A48 File Offset: 0x00033C48
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawSystem()
		{
			Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr);
			DecalDrawSystem.NativeFieldInfoPtr_MaxBatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "MaxBatchSize");
			DecalDrawSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "m_EntityManager");
			DecalDrawSystem.NativeFieldInfoPtr_m_WorldToDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "m_WorldToDecals");
			DecalDrawSystem.NativeFieldInfoPtr_m_NormalToDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "m_NormalToDecals");
			DecalDrawSystem.NativeFieldInfoPtr_m_DecalLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "m_DecalLayerMasks");
			DecalDrawSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "m_Sampler");
			DecalDrawSystem.NativeFieldInfoPtr__overrideMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, "<overrideMaterial>k__BackingField");
			DecalDrawSystem.NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664566);
			DecalDrawSystem.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664567);
			DecalDrawSystem.NativeMethodInfoPtr__ctor_Public_Void_String_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664568);
			DecalDrawSystem.NativeMethodInfoPtr_Execute_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664569);
			DecalDrawSystem.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_DecalEntityChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664570);
			DecalDrawSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Abstract_Virtual_New_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664571);
			DecalDrawSystem.NativeMethodInfoPtr_Execute_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664572);
			DecalDrawSystem.NativeMethodInfoPtr_Draw_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664573);
			DecalDrawSystem.NativeMethodInfoPtr_DrawInstanced_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664574);
			DecalDrawSystem.NativeMethodInfoPtr_Execute_Public_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664575);
			DecalDrawSystem.NativeMethodInfoPtr_Execute_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664576);
			DecalDrawSystem.NativeMethodInfoPtr_Draw_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664577);
			DecalDrawSystem.NativeMethodInfoPtr_DrawInstanced_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr, 100664578);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00035C08 File Offset: 0x00033E08
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00035C48 File Offset: 0x00033E48
		public unsafe Material overrideMaterial
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00035C8C File Offset: 0x00033E8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 606864, RefRangeEnd = 606869, XrefRangeStart = 606840, XrefRangeEnd = 606864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawSystem(string sampler, DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sampler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr__ctor_Public_Void_String_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00035CEC File Offset: 0x00033EEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 606896, RefRangeEnd = 606900, XrefRangeStart = 606869, XrefRangeEnd = 606896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Execute_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00035D30 File Offset: 0x00033F30
		[CallerCount(0)]
		public unsafe virtual Material GetMaterial(DecalEntityChunk decalEntityChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawSystem.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_DecalEntityChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00035D8C File Offset: 0x00033F8C
		[CallerCount(0)]
		public unsafe virtual int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Abstract_Virtual_New_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00035DE4 File Offset: 0x00033FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606900, XrefRangeEnd = 606909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Execute_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00035E6C File Offset: 0x0003406C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606922, RefRangeEnd = 606923, XrefRangeStart = 606909, XrefRangeEnd = 606922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Draw_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00035EF4 File Offset: 0x000340F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 606950, RefRangeEnd = 606952, XrefRangeStart = 606923, XrefRangeEnd = 606950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawInstanced(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_DrawInstanced_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00035F7C File Offset: 0x0003417C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606979, RefRangeEnd = 606982, XrefRangeStart = 606952, XrefRangeEnd = 606979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute([In] ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Execute_Public_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00035FC0 File Offset: 0x000341C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606982, XrefRangeEnd = 606991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute([In] ref CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Execute_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00036048 File Offset: 0x00034248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607004, RefRangeEnd = 607005, XrefRangeStart = 606991, XrefRangeEnd = 607004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw([In] ref CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_Draw_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000360C4 File Offset: 0x000342C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 607035, RefRangeEnd = 607037, XrefRangeStart = 607005, XrefRangeEnd = 607035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawInstanced([In] ref CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalEntityChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalDrawCallChunk);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawSystem.NativeMethodInfoPtr_DrawInstanced_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00006166 File Offset: 0x00004366
		public DecalDrawSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00036140 File Offset: 0x00034340
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0000616F File Offset: 0x0000436F
		public unsafe static uint MaxBatchSize
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(DecalDrawSystem.NativeFieldInfoPtr_MaxBatchSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalDrawSystem.NativeFieldInfoPtr_MaxBatchSize, (void*)(&value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0003615C File Offset: 0x0003435C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0000617D File Offset: 0x0000437D
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0003618C File Offset: 0x0003438C
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0000619C File Offset: 0x0000439C
		public unsafe Il2CppStructArray<Matrix4x4> m_WorldToDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_WorldToDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_WorldToDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x000361BC File Offset: 0x000343BC
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x000061BB File Offset: 0x000043BB
		public unsafe Il2CppStructArray<Matrix4x4> m_NormalToDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_NormalToDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_NormalToDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000361EC File Offset: 0x000343EC
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x000061DA File Offset: 0x000043DA
		public unsafe Il2CppStructArray<float> m_DecalLayerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_DecalLayerMasks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_DecalLayerMasks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003621C File Offset: 0x0003441C
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x000061F9 File Offset: 0x000043F9
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0003624C File Offset: 0x0003444C
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00006218 File Offset: 0x00004418
		public unsafe Material _overrideMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr__overrideMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawSystem.NativeFieldInfoPtr__overrideMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_MaxBatchSize;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldToDecals;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalToDecals;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalLayerMasks;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr__overrideMaterial_k__BackingField;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideMaterial_Public_get_Material_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DecalEntityManager_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_CommandBuffer_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_DecalEntityChunk_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Abstract_Virtual_New_Int32_DecalCachedChunk_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_DrawInstanced_Private_Void_CommandBuffer_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_byref_CameraData_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_Int32_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_DrawInstanced_Private_Void_byref_CameraData_DecalEntityChunk_DecalCachedChunk_DecalDrawCallChunk_0;
	}
}
