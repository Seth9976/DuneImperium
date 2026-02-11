using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CE RID: 206
	public class EventBase<T> : EventBase where T : EventBase<T>, new()
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0005D8BC File Offset: 0x0005BABC
		// Note: this type is marked as 'beforefieldinit'.
		static EventBase()
		{
			Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr);
			EventBase<T>.NativeFieldInfoPtr_s_TypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "s_TypeId");
			EventBase<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "s_Pool");
			EventBase<T>.NativeFieldInfoPtr_m_RefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "m_RefCount");
			EventBase<T>.NativeFieldInfoPtr_EventCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "EventCategory");
			EventBase<T>.NativeMethodInfoPtr_SetCreateFunction_Internal_Static_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665914);
			EventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665915);
			EventBase<T>.NativeMethodInfoPtr_TypeId_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665916);
			EventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665917);
			EventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665918);
			EventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665919);
			EventBase<T>.NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665920);
			EventBase<T>.NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665921);
			EventBase<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665922);
			EventBase<T>.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100665923);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0005DA40 File Offset: 0x0005BC40
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 312653, RefRangeEnd = 312675, XrefRangeStart = 312646, XrefRangeEnd = 312653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCreateFunction(Func<T> createMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(createMethod);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_SetCreateFunction_Internal_Static_Void_Func_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0005DA78 File Offset: 0x0005BC78
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 312679, RefRangeEnd = 312699, XrefRangeStart = 312675, XrefRangeEnd = 312679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0005DAB4 File Offset: 0x0005BCB4
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 312703, RefRangeEnd = 312773, XrefRangeStart = 312699, XrefRangeEnd = 312703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TypeId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_TypeId_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 312780, RefRangeEnd = 312794, XrefRangeStart = 312773, XrefRangeEnd = 312780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0005DB20 File Offset: 0x0005BD20
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 312802, RefRangeEnd = 312827, XrefRangeStart = 312794, XrefRangeEnd = 312802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0005DB50 File Offset: 0x0005BD50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312840, RefRangeEnd = 312843, XrefRangeStart = 312827, XrefRangeEnd = 312840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(EventBase e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0005DB90 File Offset: 0x0005BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312843, XrefRangeEnd = 312852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePooled(T evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = evt;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref evt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0005DBFC File Offset: 0x0005BDFC
		[CallerCount(0)]
		public unsafe override void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0005DC38 File Offset: 0x0005BE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312852, XrefRangeEnd = 312865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0005DC6C File Offset: 0x0005BE6C
		public unsafe override long eventTypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312865, XrefRangeEnd = 312867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000091BE File Offset: 0x000073BE
		public EventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x000091C7 File Offset: 0x000073C7
		public unsafe static long s_TypeId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(EventBase<T>.NativeFieldInfoPtr_s_TypeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase<T>.NativeFieldInfoPtr_s_TypeId, (void*)(&value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0005DCD0 File Offset: 0x0005BED0
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x000091D5 File Offset: 0x000073D5
		public unsafe static ObjectPool<T> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventBase<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0005DCF8 File Offset: 0x0005BEF8
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000091E7 File Offset: 0x000073E7
		public unsafe int m_RefCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase<T>.NativeFieldInfoPtr_m_RefCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase<T>.NativeFieldInfoPtr_m_RefCount)) = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x0005DD20 File Offset: 0x0005BF20
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00009202 File Offset: 0x00007402
		public unsafe static EventCategory EventCategory
		{
			get
			{
				EventCategory eventCategory;
				IL2CPP.il2cpp_field_static_get_value(EventBase<T>.NativeFieldInfoPtr_EventCategory, (void*)(&eventCategory));
				return eventCategory;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase<T>.NativeFieldInfoPtr_EventCategory, (void*)(&value));
			}
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeId;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_m_RefCount;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_EventCategory;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_SetCreateFunction_Internal_Static_Void_Func_1_T_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_TypeId_Public_Static_Int64_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0;

		// Token: 0x020003FA RID: 1018
		[ObfuscatedName("UnityEngine.UIElements.EventBase`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003AB7 RID: 15031 RVA: 0x000ED69C File Offset: 0x000EB89C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr);
				EventBase<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr, "<>9");
				EventBase<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr, 100665926);
				EventBase<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr, 100665927);
			}

			// Token: 0x06003AB8 RID: 15032 RVA: 0x000ED740 File Offset: 0x000EB940
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AB9 RID: 15033 RVA: 0x000ED77C File Offset: 0x000EB97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T __cctor_b__15_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06003ABA RID: 15034 RVA: 0x00018C94 File Offset: 0x00016E94
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FB RID: 4603
			// (get) Token: 0x06003ABB RID: 15035 RVA: 0x000ED7B8 File Offset: 0x000EB9B8
			// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00018C9D File Offset: 0x00016E9D
			public unsafe static EventBase<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventBase<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventBase<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventBase<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002989 RID: 10633
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400298A RID: 10634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400298B RID: 10635
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_T_0;
		}
	}
}
