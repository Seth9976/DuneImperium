using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200001D RID: 29
	public sealed class RenderGraphPass<PassData> : RenderGraphPass where PassData : class, new()
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00018064 File Offset: 0x00016264
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphPass()
		{
			Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphPass`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr);
			RenderGraphPass<PassData>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, "data");
			RenderGraphPass<PassData>.NativeFieldInfoPtr_renderFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, "renderFunc");
			RenderGraphPass<PassData>.NativeMethodInfoPtr_Execute_Public_Virtual_Void_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, 100663651);
			RenderGraphPass<PassData>.NativeMethodInfoPtr_Initialize_Public_Void_Int32_PassData_String_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, 100663652);
			RenderGraphPass<PassData>.NativeMethodInfoPtr_Release_Public_Virtual_Void_RenderGraphObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, 100663653);
			RenderGraphPass<PassData>.NativeMethodInfoPtr_HasRenderFunc_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, 100663654);
			RenderGraphPass<PassData>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr, 100663655);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001815C File Offset: 0x0001635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957336, XrefRangeEnd = 957338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(RenderGraphContext renderGraphContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraphContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass<PassData>.NativeMethodInfoPtr_Execute_Public_Virtual_Void_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000181A0 File Offset: 0x000163A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957343, RefRangeEnd = 957345, XrefRangeStart = 957338, XrefRangeEnd = 957343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref passIndex;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(PassData).IsValueType)
			{
				PassData passData2 = passData;
				intPtr = ((passData2 is string) ? IL2CPP.ManagedStringToIl2Cpp(passData2 as string) : IL2CPP.Il2CppObjectBaseToPtr(passData2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref passData;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(passName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sampler);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass<PassData>.NativeMethodInfoPtr_Initialize_Public_Void_Int32_PassData_String_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001824C File Offset: 0x0001644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957345, XrefRangeEnd = 957350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(RenderGraphObjectPool pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass<PassData>.NativeMethodInfoPtr_Release_Public_Virtual_Void_RenderGraphObjectPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00018290 File Offset: 0x00016490
		[CallerCount(0)]
		public unsafe override bool HasRenderFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass<PassData>.NativeMethodInfoPtr_HasRenderFunc_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000182CC File Offset: 0x000164CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957350, XrefRangeEnd = 957351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphPass<PassData>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass<PassData>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000033F3 File Offset: 0x000015F3
		public RenderGraphPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00018308 File Offset: 0x00016508
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00018330 File Offset: 0x00016530
		public unsafe PassData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass<PassData>.NativeFieldInfoPtr_data);
				return IL2CPP.PointerToValueGeneric<PassData>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass<PassData>.NativeFieldInfoPtr_data);
				Type typeFromHandle = typeof(PassData);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000183D8 File Offset: 0x000165D8
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000033FC File Offset: 0x000015FC
		public unsafe RenderFunc<PassData> renderFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass<PassData>.NativeFieldInfoPtr_renderFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<PassData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass<PassData>.NativeFieldInfoPtr_renderFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_renderFunc;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_RenderGraphContext_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_PassData_String_ProfilingSampler_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_RenderGraphObjectPool_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_HasRenderFunc_Public_Virtual_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
