using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Requests
{
	// Token: 0x02000015 RID: 21
	public sealed class PageStreamer<TResource, TRequest, TResponse, TToken> : Object where TToken : class
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000A7AC File Offset: 0x000089AC
		// Note: this type is marked as 'beforefieldinit'.
		static PageStreamer()
		{
			Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "PageStreamer`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TToken>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr);
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_emptyResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "emptyResources");
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_requestModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "requestModifier");
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_tokenExtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "tokenExtractor");
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_resourceExtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "resourceExtractor");
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr__ctor_Public_Void_Action_2_TRequest_TToken_Func_2_TResponse_TToken_Func_2_TResponse_IEnumerable_1_TResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, 100663605);
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr_Fetch_Public_IEnumerable_1_TResource_TRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, 100663606);
			PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr_FetchAllAsync_Public_Task_1_IList_1_TResource_TRequest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, 100663607);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000A8DC File Offset: 0x00008ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198742, XrefRangeEnd = 1198761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PageStreamer(Action<TRequest, TToken> requestModifier, Func<TResponse, TToken> tokenExtractor, Func<TResponse, IEnumerable<TResource>> resourceExtractor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestModifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenExtractor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceExtractor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr__ctor_Public_Void_Action_2_TRequest_TToken_Func_2_TResponse_TToken_Func_2_TResponse_IEnumerable_1_TResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000A94C File Offset: 0x00008B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198761, XrefRangeEnd = 1198769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TResource> Fetch(TRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TRequest).IsValueType)
				{
					TRequest trequest = request;
					intPtr = ((trequest is string) ? IL2CPP.ManagedStringToIl2Cpp(trequest as string) : IL2CPP.Il2CppObjectBaseToPtr(trequest as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr_Fetch_Public_IEnumerable_1_TResource_TRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResource>>(intPtr4) : null;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198769, XrefRangeEnd = 1198792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IList<TResource>> FetchAllAsync(TRequest request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TRequest).IsValueType)
				{
					TRequest trequest = request;
					intPtr = ((trequest is string) ? IL2CPP.ManagedStringToIl2Cpp(trequest as string) : IL2CPP.Il2CppObjectBaseToPtr(trequest as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeMethodInfoPtr_FetchAllAsync_Public_Task_1_IList_1_TResource_TRequest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<IList<TResource>>>(intPtr4) : null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000275A File Offset: 0x0000095A
		public PageStreamer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000AA74 File Offset: 0x00008C74
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002763 File Offset: 0x00000963
		public unsafe static Il2CppArrayBase<TResource> emptyResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_emptyResources, (void*)(&intPtr));
				return Il2CppArrayBase<TResource>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_emptyResources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000AA94 File Offset: 0x00008C94
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe Action<TRequest, TToken> requestModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_requestModifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TRequest, TToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_requestModifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe Func<TResponse, TToken> tokenExtractor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_tokenExtractor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TResponse, TToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_tokenExtractor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000027B3 File Offset: 0x000009B3
		public unsafe Func<TResponse, IEnumerable<TResource>> resourceExtractor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_resourceExtractor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TResponse, IEnumerable<TResource>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>.NativeFieldInfoPtr_resourceExtractor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_emptyResources;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_requestModifier;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_tokenExtractor;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_resourceExtractor;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_2_TRequest_TToken_Func_2_TResponse_TToken_Func_2_TResponse_IEnumerable_1_TResource_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Public_IEnumerable_1_TResource_TRequest_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_FetchAllAsync_Public_Task_1_IList_1_TResource_TRequest_CancellationToken_0;

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("Google.Apis.Requests.PageStreamer`4+<Fetch>d__5")]
		public sealed class _Fetch_d__5 : Object
		{
			// Token: 0x060003BB RID: 955 RVA: 0x000114D8 File Offset: 0x0000F6D8
			// Note: this type is marked as 'beforefieldinit'.
			static _Fetch_d__5()
			{
				Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "<Fetch>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TToken>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>1__state");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>2__current");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>l__initialThreadId");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "request");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___3__request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>3__request");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>4__this");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<token>5__2");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, "<>7__wrap2");
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663609);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663610);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663611);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663612);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResource__get_Current_Private_Virtual_Final_New_get_TResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663613);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663614);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663615);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663616);
				PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr, 100663617);
			}

			// Token: 0x060003BC RID: 956 RVA: 0x000116C8 File Offset: 0x0000F8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Fetch_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00011710 File Offset: 0x0000F910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00011744 File Offset: 0x0000F944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198536, XrefRangeEnd = 1198606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00011780 File Offset: 0x0000F980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198606, XrefRangeEnd = 1198614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x000117B4 File Offset: 0x0000F9B4
			public unsafe TResource System.Collections.Generic.IEnumerator<TResource>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198614, XrefRangeEnd = 1198618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResource__get_Current_Private_Virtual_Final_New_get_TResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResource>(intPtr, false, true);
				}
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x000117F0 File Offset: 0x0000F9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00011824 File Offset: 0x0000FA24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198618, XrefRangeEnd = 1198622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00011864 File Offset: 0x0000FA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198622, XrefRangeEnd = 1198638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResource> System_Collections_Generic_IEnumerable_TResource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResource>>(intPtr3) : null;
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x000118A4 File Offset: 0x0000FAA4
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000419B File Offset: 0x0000239B
			public _Fetch_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x000118E4 File Offset: 0x0000FAE4
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x000041A4 File Offset: 0x000023A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001190C File Offset: 0x0000FB0C
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00011934 File Offset: 0x0000FB34
			public unsafe TResource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResource);
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

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060003CA RID: 970 RVA: 0x000119DC File Offset: 0x0000FBDC
			// (set) Token: 0x060003CB RID: 971 RVA: 0x000041BF File Offset: 0x000023BF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00011A04 File Offset: 0x0000FC04
			// (set) Token: 0x060003CD RID: 973 RVA: 0x00011A2C File Offset: 0x0000FC2C
			public unsafe TRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr_request);
					return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr_request);
					Type typeFromHandle = typeof(TRequest);
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

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00011AD4 File Offset: 0x0000FCD4
			// (set) Token: 0x060003CF RID: 975 RVA: 0x00011AFC File Offset: 0x0000FCFC
			public unsafe TRequest __3__request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___3__request);
					return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___3__request);
					Type typeFromHandle = typeof(TRequest);
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

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x00011BA4 File Offset: 0x0000FDA4
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x000041DA File Offset: 0x000023DA
			public unsafe PageStreamer<TResource, TRequest, TResponse, TToken> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PageStreamer<TResource, TRequest, TResponse, TToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x00011BD4 File Offset: 0x0000FDD4
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x00011BFC File Offset: 0x0000FDFC
			public unsafe TToken _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr__token_5__2);
					return IL2CPP.PointerToValueGeneric<TToken>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr__token_5__2);
					Type typeFromHandle = typeof(TToken);
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

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x00011CA4 File Offset: 0x0000FEA4
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x000041F9 File Offset: 0x000023F9
			public unsafe IEnumerator<TResource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._Fetch_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeFieldInfoPtr___3__request;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResource__get_Current_Private_Virtual_Final_New_get_TResource_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResource_0;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("Google.Apis.Requests.PageStreamer`4+<FetchAllAsync>d__6")]
		public sealed class _FetchAllAsync_d__6 : ValueType
		{
			// Token: 0x060003D6 RID: 982 RVA: 0x00011CD4 File Offset: 0x0000FED4
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchAllAsync_d__6()
			{
				Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>>.NativeClassPtr, "<FetchAllAsync>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TToken>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr);
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "<>1__state");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "<>t__builder");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "request");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "cancellationToken");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "<>4__this");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr__results_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "<results>5__2");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, "<>u__1");
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, 100663618);
				PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr, 100663619);
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00011E24 File Offset: 0x00010024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198638, XrefRangeEnd = 1198735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00011E5C File Offset: 0x0001005C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198735, XrefRangeEnd = 1198742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00004218 File Offset: 0x00002418
			public _FetchAllAsync_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00004221 File Offset: 0x00002421
			public _FetchAllAsync_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00011EA4 File Offset: 0x000100A4
			// (set) Token: 0x060003DC RID: 988 RVA: 0x00004233 File Offset: 0x00002433
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060003DD RID: 989 RVA: 0x00011ECC File Offset: 0x000100CC
			// (set) Token: 0x060003DE RID: 990 RVA: 0x0000424E File Offset: 0x0000244E
			public AsyncTaskMethodBuilder<IList<TResource>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IList<TResource>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IList<TResource>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IList<TResource>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060003DF RID: 991 RVA: 0x00011EFC File Offset: 0x000100FC
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x00011F24 File Offset: 0x00010124
			public unsafe TRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_request);
					return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_request);
					Type typeFromHandle = typeof(TRequest);
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

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00011FCC File Offset: 0x000101CC
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000427C File Offset: 0x0000247C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00011FFC File Offset: 0x000101FC
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x000042AA File Offset: 0x000024AA
			public unsafe PageStreamer<TResource, TRequest, TResponse, TToken> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PageStreamer<TResource, TRequest, TResponse, TToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x0001202C File Offset: 0x0001022C
			// (set) Token: 0x060003E6 RID: 998 RVA: 0x000042C9 File Offset: 0x000024C9
			public unsafe List<TResource> _results_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr__results_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TResource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr__results_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x0001205C File Offset: 0x0001025C
			// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000042E8 File Offset: 0x000024E8
			public ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageStreamer<TResource, TRequest, TResponse, TToken>._FetchAllAsync_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeFieldInfoPtr__results_5__2;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
