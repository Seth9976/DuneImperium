using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.endorsement
{
	// Token: 0x020001BB RID: 443
	public class SubscribableEndorser<T> : MonoBehaviour where T : Request
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x00076074 File Offset: 0x00074274
		// Note: this type is marked as 'beforefieldinit'.
		static SubscribableEndorser()
		{
			Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.endorsement", "SubscribableEndorser`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr);
			SubscribableEndorser<T>.NativeFieldInfoPtr_handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, "handlers");
			SubscribableEndorser<T>.NativeMethodInfoPtr_Subscribe_Public_Void_IRequestHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667222);
			SubscribableEndorser<T>.NativeMethodInfoPtr_Unsubscribe_Public_Void_IRequestHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667223);
			SubscribableEndorser<T>.NativeMethodInfoPtr_Endorse_Public_Virtual_Final_New_Coroutine_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667224);
			SubscribableEndorser<T>.NativeMethodInfoPtr_endorse_Protected_Virtual_New_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667225);
			SubscribableEndorser<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667226);
			SubscribableEndorser<T>.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667227);
			SubscribableEndorser<T>.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, 100667228);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00076180 File Offset: 0x00074380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880648, RefRangeEnd = 880649, XrefRangeStart = 880646, XrefRangeEnd = 880648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe(IRequestHandler<T> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr_Subscribe_Public_Void_IRequestHandler_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000761C4 File Offset: 0x000743C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880651, RefRangeEnd = 880652, XrefRangeStart = 880649, XrefRangeEnd = 880651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsubscribe(IRequestHandler<T> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr_Unsubscribe_Public_Void_IRequestHandler_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00076208 File Offset: 0x00074408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880657, RefRangeEnd = 880658, XrefRangeStart = 880652, XrefRangeEnd = 880657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Coroutine Endorse(T request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = request;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr_Endorse_Public_Virtual_Final_New_Coroutine_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr4) : null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00076290 File Offset: 0x00074490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880658, XrefRangeEnd = 880663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator endorse(T request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = request;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubscribableEndorser<T>.NativeMethodInfoPtr_endorse_Protected_Virtual_New_IEnumerator_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00076324 File Offset: 0x00074524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 880668, RefRangeEnd = 880671, XrefRangeStart = 880663, XrefRangeEnd = 880668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscribableEndorser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00076360 File Offset: 0x00074560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880671, XrefRangeEnd = 880673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000763A0 File Offset: 0x000745A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880673, XrefRangeEnd = 880675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000AD43 File Offset: 0x00008F43
		public SubscribableEndorser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000763E0 File Offset: 0x000745E0
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000AD4C File Offset: 0x00008F4C
		public unsafe HashSet<IRequestHandler<T>> handlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>.NativeFieldInfoPtr_handlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IRequestHandler<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>.NativeFieldInfoPtr_handlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_handlers;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_IRequestHandler_1_T_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_IRequestHandler_1_T_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_Endorse_Public_Virtual_Final_New_Coroutine_T_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_endorse_Protected_Virtual_New_IEnumerator_T_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("dwd.core.endorsement.SubscribableEndorser`1+<endorse>d__4")]
		public sealed class _endorse_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600275E RID: 10078 RVA: 0x000A7260 File Offset: 0x000A5460
			// Note: this type is marked as 'beforefieldinit'.
			static _endorse_d__4()
			{
				Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubscribableEndorser<T>>.NativeClassPtr, "<endorse>d__4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr);
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "<>1__state");
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "<>2__current");
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "<>4__this");
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "request");
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "<>7__wrap1");
				SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr__context_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, "<context>5__3");
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667229);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667230);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667231);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667232);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667233);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667234);
				SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr, 100667235);
			}

			// Token: 0x0600275F RID: 10079 RVA: 0x000A73CC File Offset: 0x000A55CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _endorse_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscribableEndorser<T>._endorse_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002760 RID: 10080 RVA: 0x000A7414 File Offset: 0x000A5614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880614, XrefRangeEnd = 880617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002761 RID: 10081 RVA: 0x000A7448 File Offset: 0x000A5648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880617, XrefRangeEnd = 880640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x000A7484 File Offset: 0x000A5684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880640, XrefRangeEnd = 880646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06002763 RID: 10083 RVA: 0x000A74B8 File Offset: 0x000A56B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002764 RID: 10084 RVA: 0x000A74F8 File Offset: 0x000A56F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06002765 RID: 10085 RVA: 0x000A752C File Offset: 0x000A572C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscribableEndorser<T>._endorse_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002766 RID: 10086 RVA: 0x00011E18 File Offset: 0x00010018
			public _endorse_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06002767 RID: 10087 RVA: 0x000A756C File Offset: 0x000A576C
			// (set) Token: 0x06002768 RID: 10088 RVA: 0x00011E21 File Offset: 0x00010021
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x06002769 RID: 10089 RVA: 0x000A7594 File Offset: 0x000A5794
			// (set) Token: 0x0600276A RID: 10090 RVA: 0x00011E3C File Offset: 0x0001003C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x0600276B RID: 10091 RVA: 0x000A75C4 File Offset: 0x000A57C4
			// (set) Token: 0x0600276C RID: 10092 RVA: 0x00011E5B File Offset: 0x0001005B
			public unsafe SubscribableEndorser<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscribableEndorser<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x0600276D RID: 10093 RVA: 0x000A75F4 File Offset: 0x000A57F4
			// (set) Token: 0x0600276E RID: 10094 RVA: 0x000A761C File Offset: 0x000A581C
			public unsafe T request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr_request);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr_request);
					Type typeFromHandle = typeof(T);
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

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x0600276F RID: 10095 RVA: 0x000A76C4 File Offset: 0x000A58C4
			// (set) Token: 0x06002770 RID: 10096 RVA: 0x00011E7A File Offset: 0x0001007A
			public List<IRequestHandler<T>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___7__wrap1);
					return new List<IRequestHandler<T>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IRequestHandler<T>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IRequestHandler<T>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06002771 RID: 10097 RVA: 0x000A76F4 File Offset: 0x000A58F4
			// (set) Token: 0x06002772 RID: 10098 RVA: 0x00011EA8 File Offset: 0x000100A8
			public unsafe IEnumerator _context_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr__context_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscribableEndorser<T>._endorse_d__4.NativeFieldInfoPtr__context_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AC1 RID: 6849
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AC2 RID: 6850
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AC3 RID: 6851
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AC4 RID: 6852
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04001AC5 RID: 6853
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001AC6 RID: 6854
			private static readonly IntPtr NativeFieldInfoPtr__context_5__3;

			// Token: 0x04001AC7 RID: 6855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AC8 RID: 6856
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AC9 RID: 6857
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001ACA RID: 6858
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001ACB RID: 6859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ACC RID: 6860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ACD RID: 6861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
