using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.platform.websocket
{
	// Token: 0x0200001A RID: 26
	public class TypedMessageDispatcher : Object
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00009B54 File Offset: 0x00007D54
		// Note: this type is marked as 'beforefieldinit'.
		static TypedMessageDispatcher()
		{
			Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "TypedMessageDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr);
			TypedMessageDispatcher.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "lockObject");
			TypedMessageDispatcher.NativeFieldInfoPtr_messageHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "messageHandlers");
			TypedMessageDispatcher.NativeFieldInfoPtr_messageQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "messageQueue");
			TypedMessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663539);
			TypedMessageDispatcher.NativeMethodInfoPtr_AddHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663540);
			TypedMessageDispatcher.NativeMethodInfoPtr_SetHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663541);
			TypedMessageDispatcher.NativeMethodInfoPtr_RemoveHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663542);
			TypedMessageDispatcher.NativeMethodInfoPtr_dwd_core_platform_websocket_IMessageDispatcher_QueueMessage_Private_Virtual_Final_New_Void_TypedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663543);
			TypedMessageDispatcher.NativeMethodInfoPtr_DispatchMessages_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663544);
			TypedMessageDispatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, 100663545);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009C4C File Offset: 0x00007E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167323, XrefRangeEnd = 1167338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedMessageDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009C88 File Offset: 0x00007E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167338, XrefRangeEnd = 1167355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddHandler<T>(TypedHandler<T> handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.MethodInfoStoreGeneric_AddHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009CCC File Offset: 0x00007ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167355, XrefRangeEnd = 1167372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHandler<T>(TypedHandler<T> handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.MethodInfoStoreGeneric_SetHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009D10 File Offset: 0x00007F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167372, XrefRangeEnd = 1167383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveHandler<T>(TypedHandler<T> handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.MethodInfoStoreGeneric_RemoveHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009D54 File Offset: 0x00007F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167383, XrefRangeEnd = 1167394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_platform_websocket_IMessageDispatcher_QueueMessage(TypedMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.NativeMethodInfoPtr_dwd_core_platform_websocket_IMessageDispatcher_QueueMessage_Private_Virtual_Final_New_Void_TypedMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00009D98 File Offset: 0x00007F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167394, XrefRangeEnd = 1167399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator DispatchMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.NativeMethodInfoPtr_DispatchMessages_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009DD8 File Offset: 0x00007FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167399, XrefRangeEnd = 1167434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000026E5 File Offset: 0x000008E5
		public TypedMessageDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00009E0C File Offset: 0x0000800C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000026EE File Offset: 0x000008EE
		public unsafe static Object lockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypedMessageDispatcher.NativeFieldInfoPtr_lockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypedMessageDispatcher.NativeFieldInfoPtr_lockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00009E34 File Offset: 0x00008034
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002700 File Offset: 0x00000900
		public unsafe Dictionary<Type, TypedMessageDispatcher.IHandlerCollection> messageHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.NativeFieldInfoPtr_messageHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, TypedMessageDispatcher.IHandlerCollection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.NativeFieldInfoPtr_messageHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00009E64 File Offset: 0x00008064
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe Queue<TypedMessage> messageQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.NativeFieldInfoPtr_messageQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<TypedMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.NativeFieldInfoPtr_messageQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_messageHandlers;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_messageQueue;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_SetHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_websocket_IMessageDispatcher_QueueMessage_Private_Virtual_Final_New_Void_TypedMessage_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_DispatchMessages_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000072 RID: 114
		public class IHandlerCollection : Il2CppObjectBase
		{
			// Token: 0x0600045F RID: 1119 RVA: 0x00004236 File Offset: 0x00002436
			// Note: this type is marked as 'beforefieldinit'.
			static IHandlerCollection()
			{
				Il2CppClassPointerStore<TypedMessageDispatcher.IHandlerCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "IHandlerCollection");
				TypedMessageDispatcher.IHandlerCollection.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_TypedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.IHandlerCollection>.NativeClassPtr, 100663547);
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x000137D8 File Offset: 0x000119D8
			[CallerCount(0)]
			public unsafe virtual void Invoke(TypedMessage msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedMessageDispatcher.IHandlerCollection.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_TypedMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00004260 File Offset: 0x00002460
			public IHandlerCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_TypedMessage_0;
		}

		// Token: 0x02000073 RID: 115
		public class HandlerCollection<T> : Object where T : TypedMessage
		{
			// Token: 0x06000462 RID: 1122 RVA: 0x00013828 File Offset: 0x00011A28
			// Note: this type is marked as 'beforefieldinit'.
			static HandlerCollection()
			{
				Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "HandlerCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr);
				TypedMessageDispatcher.HandlerCollection<T>.NativeFieldInfoPtr_typedHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, "typedHandlers");
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663548);
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Add_Public_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663549);
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Set_Public_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663550);
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Remove_Public_Boolean_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663551);
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_dwd_core_platform_websocket_TypedMessageDispatcher_IHandlerCollection_Invoke_Private_Virtual_Final_New_Void_TypedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663552);
				TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr, 100663553);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x0001391C File Offset: 0x00011B1C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1167278, RefRangeEnd = 1167287, XrefRangeStart = 1167269, XrefRangeEnd = 1167278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HandlerCollection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedMessageDispatcher.HandlerCollection<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00013958 File Offset: 0x00011B58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1167289, RefRangeEnd = 1167290, XrefRangeStart = 1167287, XrefRangeEnd = 1167289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(TypedHandler<T> handler)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Add_Public_Void_TypedHandler_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x0001399C File Offset: 0x00011B9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1167295, RefRangeEnd = 1167296, XrefRangeStart = 1167290, XrefRangeEnd = 1167295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(TypedHandler<T> handler)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Set_Public_Void_TypedHandler_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x000139E0 File Offset: 0x00011BE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1167298, RefRangeEnd = 1167299, XrefRangeStart = 1167296, XrefRangeEnd = 1167298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Remove(TypedHandler<T> handler)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Remove_Public_Boolean_TypedHandler_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00013A30 File Offset: 0x00011C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167299, XrefRangeEnd = 1167308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void dwd_core_platform_websocket_TypedMessageDispatcher_IHandlerCollection_Invoke(TypedMessage msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_dwd_core_platform_websocket_TypedMessageDispatcher_IHandlerCollection_Invoke_Private_Virtual_Final_New_Void_TypedMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00013A74 File Offset: 0x00011C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167308, XrefRangeEnd = 1167311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher.HandlerCollection<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00004269 File Offset: 0x00002469
			public HandlerCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600046A RID: 1130 RVA: 0x00013AA8 File Offset: 0x00011CA8
			// (set) Token: 0x0600046B RID: 1131 RVA: 0x00004272 File Offset: 0x00002472
			public unsafe List<TypedHandler<T>> typedHandlers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.HandlerCollection<T>.NativeFieldInfoPtr_typedHandlers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypedHandler<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher.HandlerCollection<T>.NativeFieldInfoPtr_typedHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeFieldInfoPtr_typedHandlers;

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TypedHandler_1_T_0;

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_TypedHandler_1_T_0;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TypedHandler_1_T_0;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_websocket_TypedMessageDispatcher_IHandlerCollection_Invoke_Private_Virtual_Final_New_Void_TypedMessage_0;

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000074 RID: 116
		[ObfuscatedName("dwd.core.platform.websocket.TypedMessageDispatcher+<DispatchMessages>d__10")]
		public sealed class _DispatchMessages_d__10 : Object
		{
			// Token: 0x0600046C RID: 1132 RVA: 0x00013AD8 File Offset: 0x00011CD8
			// Note: this type is marked as 'beforefieldinit'.
			static _DispatchMessages_d__10()
			{
				Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr, "<DispatchMessages>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, "<>1__state");
				TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, "<>2__current");
				TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, "<>4__this");
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663554);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663555);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663556);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663557);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663558);
				TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr, 100663559);
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00013BB8 File Offset: 0x00011DB8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DispatchMessages_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedMessageDispatcher._DispatchMessages_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00013C00 File Offset: 0x00011E00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00013C34 File Offset: 0x00011E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167311, XrefRangeEnd = 1167318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x00013C70 File Offset: 0x00011E70
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00013CB0 File Offset: 0x00011EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167318, XrefRangeEnd = 1167323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x00013CE4 File Offset: 0x00011EE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedMessageDispatcher._DispatchMessages_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00004291 File Offset: 0x00002491
			public _DispatchMessages_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00013D24 File Offset: 0x00011F24
			// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000429A File Offset: 0x0000249A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00013D4C File Offset: 0x00011F4C
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x000042B5 File Offset: 0x000024B5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00013D7C File Offset: 0x00011F7C
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x000042D4 File Offset: 0x000024D4
			public unsafe TypedMessageDispatcher __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypedMessageDispatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedMessageDispatcher._DispatchMessages_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000075 RID: 117
		private sealed class MethodInfoStoreGeneric_AddHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002CF RID: 719
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypedMessageDispatcher.NativeMethodInfoPtr_AddHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000076 RID: 118
		private sealed class MethodInfoStoreGeneric_SetHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002D0 RID: 720
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypedMessageDispatcher.NativeMethodInfoPtr_SetHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000077 RID: 119
		private sealed class MethodInfoStoreGeneric_RemoveHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002D1 RID: 721
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TypedMessageDispatcher.NativeMethodInfoPtr_RemoveHandler_Public_Virtual_Final_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<TypedMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
