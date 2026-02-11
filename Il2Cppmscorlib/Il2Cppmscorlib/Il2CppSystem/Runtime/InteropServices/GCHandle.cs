using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000398 RID: 920
	[StructLayout(2)]
	public struct GCHandle
	{
		// Token: 0x06003814 RID: 14356 RVA: 0x00111404 File Offset: 0x0010F604
		// Note: this type is marked as 'beforefieldinit'.
		static GCHandle()
		{
			Il2CppClassPointerStore<GCHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GCHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCHandle>.NativeClassPtr);
			GCHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, "handle");
			GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671666);
			GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671667);
			GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671668);
			GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671669);
			GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671670);
			GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671671);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671672);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671673);
			GCHandle.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671674);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671675);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671676);
			GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671677);
			GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671678);
			GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_IntPtr_Object_IntPtr_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671679);
			GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671680);
			GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671681);
			GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671682);
			GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671683);
			GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671684);
			GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671685);
			GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100671686);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x001115EC File Offset: 0x0010F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391587, XrefRangeEnd = 1391588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00111624 File Offset: 0x0010F824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391588, XrefRangeEnd = 1391589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00111668 File Offset: 0x0010F868
		public unsafe bool IsAllocated
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1052393, RefRangeEnd = 1052416, XrefRangeStart = 1052393, XrefRangeEnd = 1052416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x00111698 File Offset: 0x0010F898
		// (set) Token: 0x06003819 RID: 14361 RVA: 0x001116CC File Offset: 0x0010F8CC
		public unsafe Object Target
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 1391597, RefRangeEnd = 1391622, XrefRangeStart = 1391589, XrefRangeEnd = 1391597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1391623, RefRangeEnd = 1391625, XrefRangeStart = 1391622, XrefRangeEnd = 1391623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00111704 File Offset: 0x0010F904
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1391630, RefRangeEnd = 1391645, XrefRangeStart = 1391625, XrefRangeEnd = 1391630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr AddrOfPinnedObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00111734 File Offset: 0x0010F934
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1391646, RefRangeEnd = 1391659, XrefRangeStart = 1391645, XrefRangeEnd = 1391646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00111778 File Offset: 0x0010F978
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1391660, RefRangeEnd = 1391687, XrefRangeStart = 1391659, XrefRangeEnd = 1391660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x001117C8 File Offset: 0x0010F9C8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1391697, RefRangeEnd = 1391730, XrefRangeStart = 1391687, XrefRangeEnd = 1391697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Free_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x001117F0 File Offset: 0x0010F9F0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00111830 File Offset: 0x0010FA30
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1391732, RefRangeEnd = 1391748, XrefRangeStart = 1391730, XrefRangeEnd = 1391732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator GCHandle(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00111870 File Offset: 0x0010FA70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489856, RefRangeEnd = 489860, XrefRangeStart = 489856, XrefRangeEnd = 489860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckCurrentDomain(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x001118B0 File Offset: 0x0010FAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391748, XrefRangeEnd = 1391749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetTarget(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x001118F0 File Offset: 0x0010FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391749, XrefRangeEnd = 1391750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetTargetHandle(Object obj, IntPtr handle, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_IntPtr_Object_IntPtr_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00111950 File Offset: 0x0010FB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391750, XrefRangeEnd = 1391751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHandle(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00111984 File Offset: 0x0010FB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391751, XrefRangeEnd = 1391752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetAddrOfPinnedObject(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x001119C4 File Offset: 0x0010FBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391752, XrefRangeEnd = 1391753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(GCHandle a, GCHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00111A10 File Offset: 0x0010FC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391753, XrefRangeEnd = 1391757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00111A54 File Offset: 0x0010FC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00111A84 File Offset: 0x0010FC84
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1391732, RefRangeEnd = 1391748, XrefRangeStart = 1391732, XrefRangeEnd = 1391748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle FromIntPtr(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00111AC4 File Offset: 0x0010FCC4
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00014985 File Offset: 0x00012B85
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Private_Static_Object_IntPtr_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetHandle_Private_Static_IntPtr_Object_IntPtr_GCHandleType_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeMethodInfoPtr_FreeHandle_Private_Static_Void_IntPtr_0;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x04002DE7 RID: 11751
		[FieldOffset(0)]
		public IntPtr handle;
	}
}
