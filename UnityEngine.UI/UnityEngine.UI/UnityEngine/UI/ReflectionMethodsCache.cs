using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200003D RID: 61
	public class ReflectionMethodsCache : Object
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x00025E9C File Offset: 0x0002409C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionMethodsCache()
		{
			Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ReflectionMethodsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr);
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3D");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3DAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRaycastNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast2D");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAllNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "s_ReflectionMethodsCache");
			ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664571);
			ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664572);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00025F80 File Offset: 0x00024180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093486, RefRangeEnd = 1093487, XrefRangeStart = 1093261, XrefRangeEnd = 1093486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionMethodsCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00025FBC File Offset: 0x000241BC
		public unsafe static ReflectionMethodsCache Singleton
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1093495, RefRangeEnd = 1093507, XrefRangeStart = 1093487, XrefRangeEnd = 1093495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr3) : null;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public ReflectionMethodsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00025FF0 File Offset: 0x000241F0
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00004AAB File Offset: 0x00002CAB
		public unsafe ReflectionMethodsCache.Raycast3DCallback raycast3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast3DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00026020 File Offset: 0x00024220
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004ACA File Offset: 0x00002CCA
		public unsafe ReflectionMethodsCache.RaycastAllCallback raycast3DAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.RaycastAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00026050 File Offset: 0x00024250
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004AE9 File Offset: 0x00002CE9
		public unsafe ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRaycastNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00026080 File Offset: 0x00024280
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00004B08 File Offset: 0x00002D08
		public unsafe ReflectionMethodsCache.Raycast2DCallback raycast2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast2DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000260B0 File Offset: 0x000242B0
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004B27 File Offset: 0x00002D27
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000260E0 File Offset: 0x000242E0
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004B46 File Offset: 0x00002D46
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00026110 File Offset: 0x00024310
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004B65 File Offset: 0x00002D65
		public unsafe static ReflectionMethodsCache s_ReflectionMethodsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_raycast3D;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_raycast3DAll;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_getRaycastNonAlloc;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_raycast2D;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAll;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAllNonAlloc;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionMethodsCache;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0;

		// Token: 0x020000BB RID: 187
		public sealed class Raycast3DCallback : MulticastDelegate
		{
			// Token: 0x06000CFE RID: 3326 RVA: 0x00037D40 File Offset: 0x00035F40
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast3DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast3DCallback");
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664573);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664574);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664575);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100664576);
			}

			// Token: 0x06000CFF RID: 3327 RVA: 0x00037DB4 File Offset: 0x00035FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093182, XrefRangeEnd = 1093185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast3DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D00 RID: 3328 RVA: 0x00037E10 File Offset: 0x00036010
			[CallerCount(0)]
			public unsafe bool Invoke(Ray r, out RaycastHit hit, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D01 RID: 3329 RVA: 0x00037E84 File Offset: 0x00036084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093185, XrefRangeEnd = 1093198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D02 RID: 3330 RVA: 0x00037F20 File Offset: 0x00036120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out RaycastHit hit, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &hit;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x00006F1E File Offset: 0x0000511E
			public Raycast3DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000A21 RID: 2593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A22 RID: 2594
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

			// Token: 0x04000A23 RID: 2595
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A24 RID: 2596
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000BC RID: 188
		public sealed class RaycastAllCallback : MulticastDelegate
		{
			// Token: 0x06000D04 RID: 3332 RVA: 0x00037F7C File Offset: 0x0003617C
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "RaycastAllCallback");
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664577);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664578);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664579);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100664580);
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x00037FF0 File Offset: 0x000361F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093198, XrefRangeEnd = 1093201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x0003804C File Offset: 0x0003624C
			[CallerCount(0)]
			public unsafe Il2CppStructArray<RaycastHit> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}

			// Token: 0x06000D07 RID: 3335 RVA: 0x000380B4 File Offset: 0x000362B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093201, XrefRangeEnd = 1093211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x00038144 File Offset: 0x00036344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
				}
			}

			// Token: 0x06000D09 RID: 3337 RVA: 0x00006F27 File Offset: 0x00005127
			public RaycastAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00006F30 File Offset: 0x00005130
			public static implicit operator ReflectionMethodsCache.RaycastAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.RaycastAllCallback>(A_0);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x00006F38 File Offset: 0x00005138
			public static ReflectionMethodsCache.RaycastAllCallback operator +(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.RaycastAllCallback>();
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00006F46 File Offset: 0x00005146
			public static ReflectionMethodsCache.RaycastAllCallback operator -(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.RaycastAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000A25 RID: 2597
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A26 RID: 2598
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

			// Token: 0x04000A27 RID: 2599
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A28 RID: 2600
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000BD RID: 189
		public sealed class GetRaycastNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000D0D RID: 3341 RVA: 0x00038194 File Offset: 0x00036394
			// Note: this type is marked as 'beforefieldinit'.
			static GetRaycastNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRaycastNonAllocCallback");
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664581);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664582);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664583);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100664584);
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00038208 File Offset: 0x00036408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093211, XrefRangeEnd = 1093214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRaycastNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x00038264 File Offset: 0x00036464
			[CallerCount(0)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x000382DC File Offset: 0x000364DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093214, XrefRangeEnd = 1093224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x0003837C File Offset: 0x0003657C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D12 RID: 3346 RVA: 0x00006F57 File Offset: 0x00005157
			public GetRaycastNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D13 RID: 3347 RVA: 0x00006F60 File Offset: 0x00005160
			public static implicit operator ReflectionMethodsCache.GetRaycastNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRaycastNonAllocCallback>(A_0);
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x00006F68 File Offset: 0x00005168
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator +(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x00006F76 File Offset: 0x00005176
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator -(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000A29 RID: 2601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A2A RID: 2602
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

			// Token: 0x04000A2B RID: 2603
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A2C RID: 2604
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x020000BE RID: 190
		public sealed class Raycast2DCallback : MulticastDelegate
		{
			// Token: 0x06000D16 RID: 3350 RVA: 0x000383CC File Offset: 0x000365CC
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast2DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast2DCallback");
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664585);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664586);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664587);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100664588);
			}

			// Token: 0x06000D17 RID: 3351 RVA: 0x00038440 File Offset: 0x00036640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093224, XrefRangeEnd = 1093227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast2DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D18 RID: 3352 RVA: 0x0003849C File Offset: 0x0003669C
			[CallerCount(0)]
			public unsafe RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D19 RID: 3353 RVA: 0x00038510 File Offset: 0x00036710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093227, XrefRangeEnd = 1093239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x000385AC File Offset: 0x000367AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093239, XrefRangeEnd = 1093241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHit2D EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D1B RID: 3355 RVA: 0x00006F87 File Offset: 0x00005187
			public Raycast2DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x00006F90 File Offset: 0x00005190
			public static implicit operator ReflectionMethodsCache.Raycast2DCallback(Func<Vector2, Vector2, float, int, RaycastHit2D> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.Raycast2DCallback>(A_0);
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x00006F98 File Offset: 0x00005198
			public static ReflectionMethodsCache.Raycast2DCallback operator +(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.Raycast2DCallback>();
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x00006FA6 File Offset: 0x000051A6
			public static ReflectionMethodsCache.Raycast2DCallback operator -(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.Raycast2DCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000A2D RID: 2605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A2E RID: 2606
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

			// Token: 0x04000A2F RID: 2607
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A30 RID: 2608
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000BF RID: 191
		public sealed class GetRayIntersectionAllCallback : MulticastDelegate
		{
			// Token: 0x06000D1F RID: 3359 RVA: 0x000385FC File Offset: 0x000367FC
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllCallback");
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664589);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664590);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664591);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100664592);
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x00038670 File Offset: 0x00036870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x000386CC File Offset: 0x000368CC
			[CallerCount(0)]
			public unsafe Il2CppStructArray<RaycastHit2D> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
			}

			// Token: 0x06000D22 RID: 3362 RVA: 0x00038734 File Offset: 0x00036934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093241, XrefRangeEnd = 1093251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D23 RID: 3363 RVA: 0x000387C4 File Offset: 0x000369C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit2D> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
				}
			}

			// Token: 0x06000D24 RID: 3364 RVA: 0x00006FB7 File Offset: 0x000051B7
			public GetRayIntersectionAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x00006FC0 File Offset: 0x000051C0
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit2D>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllCallback>(A_0);
			}

			// Token: 0x06000D26 RID: 3366 RVA: 0x00006FC8 File Offset: 0x000051C8
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
			}

			// Token: 0x06000D27 RID: 3367 RVA: 0x00006FD6 File Offset: 0x000051D6
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000A31 RID: 2609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A32 RID: 2610
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

			// Token: 0x04000A33 RID: 2611
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A34 RID: 2612
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000C0 RID: 192
		public sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000D28 RID: 3368 RVA: 0x00038814 File Offset: 0x00036A14
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllNonAllocCallback");
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664593);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664594);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664595);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100664596);
			}

			// Token: 0x06000D29 RID: 3369 RVA: 0x00038888 File Offset: 0x00036A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D2A RID: 3370 RVA: 0x000388E4 File Offset: 0x00036AE4
			[CallerCount(0)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D2B RID: 3371 RVA: 0x0003895C File Offset: 0x00036B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093251, XrefRangeEnd = 1093261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000D2C RID: 3372 RVA: 0x000389FC File Offset: 0x00036BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D2D RID: 3373 RVA: 0x00006FE7 File Offset: 0x000051E7
			public GetRayIntersectionAllNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00006FF0 File Offset: 0x000051F0
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit2D>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(A_0);
			}

			// Token: 0x06000D2F RID: 3375 RVA: 0x00006FF8 File Offset: 0x000051F8
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
			}

			// Token: 0x06000D30 RID: 3376 RVA: 0x00007006 File Offset: 0x00005206
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000A35 RID: 2613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A36 RID: 2614
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

			// Token: 0x04000A37 RID: 2615
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x04000A38 RID: 2616
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
