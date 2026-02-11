using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200040A RID: 1034
	[Serializable]
	public class EventInfo : MemberInfo
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x0011EE28 File Offset: 0x0011D028
		// Note: this type is marked as 'beforefieldinit'.
		static EventInfo()
		{
			Il2CppClassPointerStore<EventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "EventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInfo>.NativeClassPtr);
			EventInfo.NativeFieldInfoPtr_cached_add_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, "cached_add_event");
			EventInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672207);
			EventInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672208);
			EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_Final_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672209);
			EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_Final_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672210);
			EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672211);
			EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672212);
			EventInfo.NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672213);
			EventInfo.NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672214);
			EventInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672215);
			EventInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672216);
			EventInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672217);
			EventInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672218);
			EventInfo.NativeMethodInfoPtr_AddEventHandler_Public_Virtual_New_Void_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672219);
			EventInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672220);
			EventInfo.NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100672221);
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0011EF98 File Offset: 0x0011D198
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x0011EFD4 File Offset: 0x0011D1D4
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x0011F01C File Offset: 0x0011D21C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1375395, RefRangeEnd = 1375399, XrefRangeStart = 1375395, XrefRangeEnd = 1375399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetAddMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_Final_New_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x0011F05C File Offset: 0x0011D25C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1398140, RefRangeEnd = 1398143, XrefRangeStart = 1398140, XrefRangeEnd = 1398140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetRemoveMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_Final_New_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x0011F09C File Offset: 0x0011D29C
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetAddMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x0011F0F4 File Offset: 0x0011D2F4
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetRemoveMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x0011F14C File Offset: 0x0011D34C
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetRaiseMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
		public unsafe virtual Type EventHandlerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398143, XrefRangeEnd = 1398150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x0011F1F0 File Offset: 0x0011D3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x0011F248 File Offset: 0x0011D448
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x0011F290 File Offset: 0x0011D490
		[CallerCount(239)]
		[CachedScanResults(RefRangeStart = 1347122, RefRangeEnd = 1347361, XrefRangeStart = 1347122, XrefRangeEnd = 1347361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(EventInfo left, EventInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 1398150, RefRangeEnd = 1398304, XrefRangeStart = 1398150, XrefRangeEnd = 1398150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(EventInfo left, EventInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0011F338 File Offset: 0x0011D538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398304, XrefRangeEnd = 1398309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddEventHandler(Object target, Delegate handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_AddEventHandler_Public_Virtual_New_Void_Object_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x0011F398 File Offset: 0x0011D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398309, XrefRangeEnd = 1398310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref event_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0011F3E8 File Offset: 0x0011D5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398312, RefRangeEnd = 1398313, XrefRangeStart = 1398310, XrefRangeEnd = 1398312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00016482 File Offset: 0x00014682
		public EventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x0011F438 File Offset: 0x0011D638
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x0001648B File Offset: 0x0001468B
		public unsafe EventInfo.AddEventAdapter cached_add_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInfo.NativeFieldInfoPtr_cached_add_event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventInfo.AddEventAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInfo.NativeFieldInfoPtr_cached_add_event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeFieldInfoPtr_cached_add_event;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Virtual_Final_New_MethodInfo_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_Final_New_MethodInfo_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr_AddEventHandler_Public_Virtual_New_Void_Object_Delegate_0;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0;

		// Token: 0x020006B8 RID: 1720
		public sealed class AddEventAdapter : MulticastDelegate
		{
			// Token: 0x06005C94 RID: 23700 RVA: 0x0002192B File Offset: 0x0001FB2B
			// Note: this type is marked as 'beforefieldinit'.
			static AddEventAdapter()
			{
				Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, "AddEventAdapter");
				EventInfo.AddEventAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr, 100672222);
				EventInfo.AddEventAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr, 100672223);
			}

			// Token: 0x06005C95 RID: 23701 RVA: 0x001A3FE0 File Offset: 0x001A21E0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEventAdapter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.AddEventAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C96 RID: 23702 RVA: 0x001A403C File Offset: 0x001A223C
			[CallerCount(0)]
			public unsafe void Invoke(Object _this, Delegate dele)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dele);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.AddEventAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C97 RID: 23703 RVA: 0x00021969 File Offset: 0x0001FB69
			public AddEventAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005C98 RID: 23704 RVA: 0x00021972 File Offset: 0x0001FB72
			public static implicit operator EventInfo.AddEventAdapter(Action<Object, Delegate> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventInfo.AddEventAdapter>(A_0);
			}

			// Token: 0x06005C99 RID: 23705 RVA: 0x0002197A File Offset: 0x0001FB7A
			public static EventInfo.AddEventAdapter operator +(EventInfo.AddEventAdapter A_0, EventInfo.AddEventAdapter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventInfo.AddEventAdapter>();
			}

			// Token: 0x06005C9A RID: 23706 RVA: 0x00021988 File Offset: 0x0001FB88
			public static EventInfo.AddEventAdapter operator -(EventInfo.AddEventAdapter A_0, EventInfo.AddEventAdapter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventInfo.AddEventAdapter>();
				}
				return delegate2;
			}

			// Token: 0x04004B38 RID: 19256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004B39 RID: 19257
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0;
		}
	}
}
