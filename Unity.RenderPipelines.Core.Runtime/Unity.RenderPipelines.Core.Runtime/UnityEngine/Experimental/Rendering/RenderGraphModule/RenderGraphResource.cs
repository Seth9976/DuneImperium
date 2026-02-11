using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200002B RID: 43
	public class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : new() where ResType : class
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0001BD98 File Offset: 0x00019F98
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphResource()
		{
			Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphResource`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DescType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ResType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr);
			RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, "desc");
			RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_graphicsResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, "graphicsResource");
			RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, 100663798);
			RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_Reset_Public_Virtual_Void_IRenderGraphResourcePool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, 100663799);
			RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_IsCreated_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, 100663800);
			RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr, 100663801);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0001BE90 File Offset: 0x0001A090
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResource<DescType, ResType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001BECC File Offset: 0x0001A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958488, XrefRangeEnd = 958489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(IRenderGraphResourcePool pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_Reset_Public_Virtual_Void_IRenderGraphResourcePool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001BF1C File Offset: 0x0001A11C
		[CallerCount(0)]
		public unsafe override bool IsCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_IsCreated_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0001BF64 File Offset: 0x0001A164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958489, RefRangeEnd = 958490, XrefRangeStart = 958489, XrefRangeEnd = 958489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphResource<DescType, ResType>.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003869 File Offset: 0x00001A69
		public RenderGraphResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
		public unsafe DescType desc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_desc);
				return IL2CPP.PointerToValueGeneric<DescType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_desc);
				Type typeFromHandle = typeof(DescType);
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0001C070 File Offset: 0x0001A270
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0001C098 File Offset: 0x0001A298
		public unsafe ResType graphicsResource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_graphicsResource);
				return IL2CPP.PointerToValueGeneric<ResType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResource<DescType, ResType>.NativeFieldInfoPtr_graphicsResource);
				Type typeFromHandle = typeof(ResType);
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

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_desc;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_graphicsResource;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_IRenderGraphResourcePool_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_IsCreated_Public_Virtual_Boolean_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0;
	}
}
