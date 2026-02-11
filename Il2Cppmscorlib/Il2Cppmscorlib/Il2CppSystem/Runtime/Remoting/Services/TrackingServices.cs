using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020002AD RID: 685
	public class TrackingServices : Object
	{
		// Token: 0x06002BD1 RID: 11217 RVA: 0x000E6DA4 File Offset: 0x000E4FA4
		// Note: this type is marked as 'beforefieldinit'.
		static TrackingServices()
		{
			Il2CppClassPointerStore<TrackingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "TrackingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr);
			TrackingServices.NativeFieldInfoPtr__handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, "_handlers");
			TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100670381);
			TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100670382);
			TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100670383);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000E6E24 File Offset: 0x000E5024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379601, XrefRangeEnd = 1379632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyMarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000E6E6C File Offset: 0x000E506C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379663, RefRangeEnd = 1379664, XrefRangeStart = 1379632, XrefRangeEnd = 1379663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyUnmarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000E6EB4 File Offset: 0x000E50B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379695, RefRangeEnd = 1379696, XrefRangeStart = 1379664, XrefRangeEnd = 1379695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDisconnectedObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x0000E9E2 File Offset: 0x0000CBE2
		public TrackingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000E6EEC File Offset: 0x000E50EC
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0000E9EB File Offset: 0x0000CBEB
		public unsafe static ArrayList _handlers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackingServices.NativeFieldInfoPtr__handlers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackingServices.NativeFieldInfoPtr__handlers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr__handlers;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0;
	}
}
