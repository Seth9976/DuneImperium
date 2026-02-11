using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200001B RID: 27
	public sealed class RenderGraphObjectPool : Object
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00016C90 File Offset: 0x00014E90
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphObjectPool()
		{
			Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphObjectPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr);
			RenderGraphObjectPool.NativeFieldInfoPtr_m_ArrayPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, "m_ArrayPool");
			RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, "m_AllocatedArrays");
			RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedMaterialPropertyBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, "m_AllocatedMaterialPropertyBlocks");
			RenderGraphObjectPool.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663595);
			RenderGraphObjectPool.NativeMethodInfoPtr_GetTempArray_Public_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663596);
			RenderGraphObjectPool.NativeMethodInfoPtr_GetTempMaterialPropertyBlock_Public_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663597);
			RenderGraphObjectPool.NativeMethodInfoPtr_ReleaseAllTempAlloc_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663598);
			RenderGraphObjectPool.NativeMethodInfoPtr_Get_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663599);
			RenderGraphObjectPool.NativeMethodInfoPtr_Release_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663600);
			RenderGraphObjectPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, 100663601);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00016D88 File Offset: 0x00014F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957036, XrefRangeEnd = 957058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphObjectPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00016DC4 File Offset: 0x00014FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957105, RefRangeEnd = 957106, XrefRangeStart = 957058, XrefRangeEnd = 957105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetTempArray<T>(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.MethodInfoStoreGeneric_GetTempArray_Public_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00016E08 File Offset: 0x00015008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957106, XrefRangeEnd = 957119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialPropertyBlock GetTempMaterialPropertyBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.NativeMethodInfoPtr_GetTempMaterialPropertyBlock_Public_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr3) : null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00016E48 File Offset: 0x00015048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957166, RefRangeEnd = 957167, XrefRangeStart = 957119, XrefRangeEnd = 957166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAllTempAlloc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.NativeMethodInfoPtr_ReleaseAllTempAlloc_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00016E7C File Offset: 0x0001507C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 957178, RefRangeEnd = 957182, XrefRangeStart = 957167, XrefRangeEnd = 957178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get<T>() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.MethodInfoStoreGeneric_Get_Internal_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00016EB8 File Offset: 0x000150B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957188, RefRangeEnd = 957190, XrefRangeStart = 957182, XrefRangeEnd = 957188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release<T>(T value) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.MethodInfoStoreGeneric_Release_Internal_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00016F30 File Offset: 0x00015130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957190, XrefRangeEnd = 957202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000031D3 File Offset: 0x000013D3
		public RenderGraphObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00016F64 File Offset: 0x00015164
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000031DC File Offset: 0x000013DC
		public unsafe Dictionary<ValueTuple<Type, int>, Stack<Object>> m_ArrayPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_ArrayPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, int>, Stack<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_ArrayPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00016F94 File Offset: 0x00015194
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000031FB File Offset: 0x000013FB
		public unsafe List<ValueTuple<Object, ValueTuple<Type, int>>> m_AllocatedArrays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedArrays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Object, ValueTuple<Type, int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedArrays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00016FC4 File Offset: 0x000151C4
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000321A File Offset: 0x0000141A
		public unsafe List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedMaterialPropertyBlocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialPropertyBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.NativeFieldInfoPtr_m_AllocatedMaterialPropertyBlocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrayPool;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatedArrays;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatedMaterialPropertyBlocks;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_GetTempArray_Public_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_GetTempMaterialPropertyBlock_Public_MaterialPropertyBlock_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAllTempAlloc_Internal_Void_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_T_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_T_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x02000151 RID: 337
		public class SharedObjectPoolBase : Object
		{
			// Token: 0x060015A0 RID: 5536 RVA: 0x0005E12C File Offset: 0x0005C32C
			// Note: this type is marked as 'beforefieldinit'.
			static SharedObjectPoolBase()
			{
				Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, "SharedObjectPoolBase");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr);
				RenderGraphObjectPool.SharedObjectPoolBase.NativeFieldInfoPtr_s_AllocatedPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr, "s_AllocatedPools");
				RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr, 100663602);
				RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr, 100663603);
				RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr, 100663604);
			}

			// Token: 0x060015A1 RID: 5537 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
			[CallerCount(0)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015A2 RID: 5538 RVA: 0x0005E1E4 File Offset: 0x0005C3E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 956972, RefRangeEnd = 956974, XrefRangeStart = 956954, XrefRangeEnd = 956972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ClearAll()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015A3 RID: 5539 RVA: 0x0005E20C File Offset: 0x0005C40C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SharedObjectPoolBase()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPoolBase>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPoolBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015A4 RID: 5540 RVA: 0x0000AF9A File Offset: 0x0000919A
			public SharedObjectPoolBase(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x060015A5 RID: 5541 RVA: 0x0005E248 File Offset: 0x0005C448
			// (set) Token: 0x060015A6 RID: 5542 RVA: 0x0000AFA3 File Offset: 0x000091A3
			public unsafe static List<RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraphObjectPool.SharedObjectPoolBase.NativeFieldInfoPtr_s_AllocatedPools, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderGraphObjectPool.SharedObjectPoolBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphObjectPool.SharedObjectPoolBase.NativeFieldInfoPtr_s_AllocatedPools, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FCA RID: 4042
			private static readonly IntPtr NativeFieldInfoPtr_s_AllocatedPools;

			// Token: 0x04000FCB RID: 4043
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0;

			// Token: 0x04000FCC RID: 4044
			private static readonly IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

			// Token: 0x04000FCD RID: 4045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x02000152 RID: 338
		public class SharedObjectPool<T> : RenderGraphObjectPool.SharedObjectPoolBase where T : new()
		{
			// Token: 0x060015A7 RID: 5543 RVA: 0x0005E270 File Offset: 0x0005C470
			// Note: this type is marked as 'beforefieldinit'.
			static SharedObjectPool()
			{
				Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr, "SharedObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, "m_Pool");
				RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, "s_Instance");
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663606);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663607);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_AllocatePool_Private_Static_SharedObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663608);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663609);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_get_sharedPool_Public_Static_get_SharedObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663610);
				RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr, 100663611);
			}

			// Token: 0x060015A8 RID: 5544 RVA: 0x0005E378 File Offset: 0x0005C578
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 956980, RefRangeEnd = 956982, XrefRangeStart = 956974, XrefRangeEnd = 956980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T Get()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060015A9 RID: 5545 RVA: 0x0005E3B4 File Offset: 0x0005C5B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 956986, RefRangeEnd = 956988, XrefRangeStart = 956982, XrefRangeEnd = 956986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release(T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060015AA RID: 5546 RVA: 0x0005E42C File Offset: 0x0005C62C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956988, XrefRangeEnd = 957007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RenderGraphObjectPool.SharedObjectPool<T> AllocatePool()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_AllocatePool_Private_Static_SharedObjectPool_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderGraphObjectPool.SharedObjectPool<T>>(intPtr3) : null;
			}

			// Token: 0x060015AB RID: 5547 RVA: 0x0005E460 File Offset: 0x0005C660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957007, XrefRangeEnd = 957009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x060015AC RID: 5548 RVA: 0x0005E49C File Offset: 0x0005C69C
			public unsafe static RenderGraphObjectPool.SharedObjectPool<T> sharedPool
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 957024, RefRangeEnd = 957028, XrefRangeStart = 957009, XrefRangeEnd = 957024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr_get_sharedPool_Public_Static_get_SharedObjectPool_1_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderGraphObjectPool.SharedObjectPool<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060015AD RID: 5549 RVA: 0x0005E4D0 File Offset: 0x0005C6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957028, XrefRangeEnd = 957036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SharedObjectPool()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphObjectPool.SharedObjectPool<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphObjectPool.SharedObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015AE RID: 5550 RVA: 0x0000AFB5 File Offset: 0x000091B5
			public SharedObjectPool(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x060015AF RID: 5551 RVA: 0x0005E50C File Offset: 0x0005C70C
			// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0000AFBE File Offset: 0x000091BE
			public unsafe Stack<T> m_Pool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_m_Pool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0005E53C File Offset: 0x0005C73C
			// (set) Token: 0x060015B2 RID: 5554 RVA: 0x0000AFDD File Offset: 0x000091DD
			public unsafe static Lazy<RenderGraphObjectPool.SharedObjectPool<T>> s_Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<RenderGraphObjectPool.SharedObjectPool<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphObjectPool.SharedObjectPool<T>.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FCE RID: 4046
			private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

			// Token: 0x04000FCF RID: 4047
			private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

			// Token: 0x04000FD0 RID: 4048
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

			// Token: 0x04000FD1 RID: 4049
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_0;

			// Token: 0x04000FD2 RID: 4050
			private static readonly IntPtr NativeMethodInfoPtr_AllocatePool_Private_Static_SharedObjectPool_1_T_0;

			// Token: 0x04000FD3 RID: 4051
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0;

			// Token: 0x04000FD4 RID: 4052
			private static readonly IntPtr NativeMethodInfoPtr_get_sharedPool_Public_Static_get_SharedObjectPool_1_T_0;

			// Token: 0x04000FD5 RID: 4053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000153 RID: 339
		private sealed class MethodInfoStoreGeneric_GetTempArray_Public_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000FD6 RID: 4054
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphObjectPool.NativeMethodInfoPtr_GetTempArray_Public_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000154 RID: 340
		private sealed class MethodInfoStoreGeneric_Get_Internal_T_0<T>
		{
			// Token: 0x04000FD7 RID: 4055
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphObjectPool.NativeMethodInfoPtr_Get_Internal_T_0, Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000155 RID: 341
		private sealed class MethodInfoStoreGeneric_Release_Internal_Void_T_0<T>
		{
			// Token: 0x04000FD8 RID: 4056
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphObjectPool.NativeMethodInfoPtr_Release_Internal_Void_T_0, Il2CppClassPointerStore<RenderGraphObjectPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
