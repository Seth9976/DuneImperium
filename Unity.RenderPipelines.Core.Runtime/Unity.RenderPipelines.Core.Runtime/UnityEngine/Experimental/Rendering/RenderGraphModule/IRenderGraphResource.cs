using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200002A RID: 42
	public class IRenderGraphResource : Object
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0001B6A8 File Offset: 0x000198A8
		// Note: this type is marked as 'beforefieldinit'.
		static IRenderGraphResource()
		{
			Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "IRenderGraphResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr);
			IRenderGraphResource.NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "imported");
			IRenderGraphResource.NativeFieldInfoPtr_shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "shared");
			IRenderGraphResource.NativeFieldInfoPtr_sharedExplicitRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "sharedExplicitRelease");
			IRenderGraphResource.NativeFieldInfoPtr_requestFallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "requestFallBack");
			IRenderGraphResource.NativeFieldInfoPtr_writeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "writeCount");
			IRenderGraphResource.NativeFieldInfoPtr_cachedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "cachedHash");
			IRenderGraphResource.NativeFieldInfoPtr_transientPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "transientPassIndex");
			IRenderGraphResource.NativeFieldInfoPtr_sharedResourceLastFrameUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "sharedResourceLastFrameUsed");
			IRenderGraphResource.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, "m_Pool");
			IRenderGraphResource.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_IRenderGraphResourcePool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663785);
			IRenderGraphResource.NativeMethodInfoPtr_GetName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663786);
			IRenderGraphResource.NativeMethodInfoPtr_IsCreated_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663787);
			IRenderGraphResource.NativeMethodInfoPtr_IncrementWriteCount_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663788);
			IRenderGraphResource.NativeMethodInfoPtr_NeedsFallBack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663789);
			IRenderGraphResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663790);
			IRenderGraphResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663791);
			IRenderGraphResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663792);
			IRenderGraphResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663793);
			IRenderGraphResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_New_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663794);
			IRenderGraphResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_New_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663795);
			IRenderGraphResource.NativeMethodInfoPtr_GetSortIndex_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663796);
			IRenderGraphResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr, 100663797);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001B890 File Offset: 0x00019A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958485, RefRangeEnd = 958486, XrefRangeStart = 958484, XrefRangeEnd = 958485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(IRenderGraphResourcePool pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_IRenderGraphResourcePool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001B8E0 File Offset: 0x00019AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958486, XrefRangeEnd = 958488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_GetName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001B924 File Offset: 0x00019B24
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_IsCreated_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001B96C File Offset: 0x00019B6C
		[CallerCount(0)]
		public unsafe virtual void IncrementWriteCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_IncrementWriteCount_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		[CallerCount(0)]
		public unsafe virtual bool NeedsFallBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_NeedsFallBack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreatePooledGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0001BA2C File Offset: 0x00019C2C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateGraphicsResource(string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001BA7C File Offset: 0x00019C7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleasePooledGraphicsResource(int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001BB04 File Offset: 0x00019D04
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogCreation(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_New_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0001BB54 File Offset: 0x00019D54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogRelease(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_New_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetSortIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderGraphResource.NativeMethodInfoPtr_GetSortIndex_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0001BBEC File Offset: 0x00019DEC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRenderGraphResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IRenderGraphResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRenderGraphResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003769 File Offset: 0x00001969
		public IRenderGraphResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0001BC28 File Offset: 0x00019E28
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003772 File Offset: 0x00001972
		public unsafe bool imported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_imported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_imported)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0001BC50 File Offset: 0x00019E50
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000378D File Offset: 0x0000198D
		public unsafe bool shared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_shared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_shared)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0001BC78 File Offset: 0x00019E78
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000037A8 File Offset: 0x000019A8
		public unsafe bool sharedExplicitRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_sharedExplicitRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_sharedExplicitRelease)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000037C3 File Offset: 0x000019C3
		public unsafe bool requestFallBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_requestFallBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_requestFallBack)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000037DE File Offset: 0x000019DE
		public unsafe uint writeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_writeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_writeCount)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		// (set) Token: 0x060003CB RID: 971 RVA: 0x000037F9 File Offset: 0x000019F9
		public unsafe int cachedHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_cachedHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_cachedHash)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001BD18 File Offset: 0x00019F18
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00003814 File Offset: 0x00001A14
		public unsafe int transientPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_transientPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_transientPassIndex)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0001BD40 File Offset: 0x00019F40
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000382F File Offset: 0x00001A2F
		public unsafe int sharedResourceLastFrameUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_sharedResourceLastFrameUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_sharedResourceLastFrameUsed)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001BD68 File Offset: 0x00019F68
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000384A File Offset: 0x00001A4A
		public unsafe IRenderGraphResourcePool m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRenderGraphResourcePool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRenderGraphResource.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_imported;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_shared;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_sharedExplicitRelease;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_requestFallBack;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_writeCount;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_cachedHash;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_transientPassIndex;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_sharedResourceLastFrameUsed;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_IRenderGraphResourcePool_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_String_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_IsCreated_Public_Virtual_New_Boolean_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_IncrementWriteCount_Public_Virtual_New_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_NeedsFallBack_Public_Virtual_New_Boolean_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_New_Void_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_New_Void_String_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_New_Void_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_LogCreation_Public_Virtual_New_Void_RenderGraphLogger_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_LogRelease_Public_Virtual_New_Void_RenderGraphLogger_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_GetSortIndex_Public_Virtual_New_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
