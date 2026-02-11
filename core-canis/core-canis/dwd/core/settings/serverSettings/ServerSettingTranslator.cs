using System;
using dwd.core.settings.serverSettings.save;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000BB RID: 187
	public class ServerSettingTranslator<T> : Object
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x00041394 File Offset: 0x0003F594
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSettingTranslator()
		{
			Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "ServerSettingTranslator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr);
			ServerSettingTranslator<T>.NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, "storage");
			ServerSettingTranslator<T>.NativeFieldInfoPtr_fromStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, "fromStorage");
			ServerSettingTranslator<T>.NativeFieldInfoPtr_toStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, "toStorage");
			ServerSettingTranslator<T>.NativeMethodInfoPtr__ctor_Public_Void_ServerSettingStorage_FromStorage_T_ToStorage_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, 100664970);
			ServerSettingTranslator<T>.NativeMethodInfoPtr_Load_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, 100664971);
			ServerSettingTranslator<T>.NativeMethodInfoPtr_Store_Public_SaveOne_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, 100664972);
			ServerSettingTranslator<T>.NativeMethodInfoPtr_DeleteKey_Public_DeleteOne_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, 100664973);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004148C File Offset: 0x0003F68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864131, RefRangeEnd = 864132, XrefRangeStart = 864108, XrefRangeEnd = 864131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSettingTranslator(ServerSettingStorage storage, ServerSettingTranslator<T>.FromStorage fromStorage, ServerSettingTranslator<T>.ToStorage toStorage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromStorage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toStorage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.NativeMethodInfoPtr__ctor_Public_Void_ServerSettingStorage_FromStorage_T_ToStorage_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000414FC File Offset: 0x0003F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864132, XrefRangeEnd = 864134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Load(int key, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.NativeMethodInfoPtr_Load_Public_Boolean_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00041594 File Offset: 0x0003F794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864134, XrefRangeEnd = 864139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveOne Store(int key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.NativeMethodInfoPtr_Store_Public_SaveOne_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SaveOne>(intPtr4) : null;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00041628 File Offset: 0x0003F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864139, XrefRangeEnd = 864144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteOne DeleteKey(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.NativeMethodInfoPtr_DeleteKey_Public_DeleteOne_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteOne>(intPtr3) : null;
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000636E File Offset: 0x0000456E
		public ServerSettingTranslator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00041674 File Offset: 0x0003F874
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00006377 File Offset: 0x00004577
		public unsafe ServerSettingStorage storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingStorage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000416A4 File Offset: 0x0003F8A4
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00006396 File Offset: 0x00004596
		public unsafe ServerSettingTranslator<T>.FromStorage fromStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_fromStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingTranslator<T>.FromStorage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_fromStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000416D4 File Offset: 0x0003F8D4
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000063B5 File Offset: 0x000045B5
		public unsafe ServerSettingTranslator<T>.ToStorage toStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_toStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingTranslator<T>.ToStorage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingTranslator<T>.NativeFieldInfoPtr_toStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_storage;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_fromStorage;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_toStorage;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerSettingStorage_FromStorage_T_ToStorage_T_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Boolean_Int32_byref_T_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_SaveOne_Int32_T_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_DeleteOne_Int32_0;

		// Token: 0x0200029A RID: 666
		public sealed class FromStorage : MulticastDelegate
		{
			// Token: 0x06001FA2 RID: 8098 RVA: 0x0008F8E0 File Offset: 0x0008DAE0
			// Note: this type is marked as 'beforefieldinit'.
			static FromStorage()
			{
				Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, "FromStorage"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr, 100664974);
				ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr, 100664975);
				ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr, 100664976);
				ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr, 100664977);
			}

			// Token: 0x06001FA3 RID: 8099 RVA: 0x0008F98C File Offset: 0x0008DB8C
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 864047, RefRangeEnd = 864096, XrefRangeStart = 864044, XrefRangeEnd = 864047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FromStorage(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingTranslator<T>.FromStorage>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FA4 RID: 8100 RVA: 0x0008F9E8 File Offset: 0x0008DBE8
			[CallerCount(0)]
			public unsafe T Invoke(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001FA5 RID: 8101 RVA: 0x0008FA30 File Offset: 0x0008DC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864096, XrefRangeEnd = 864100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FA6 RID: 8102 RVA: 0x0008FAA0 File Offset: 0x0008DCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.FromStorage.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001FA7 RID: 8103 RVA: 0x0000D772 File Offset: 0x0000B972
			public FromStorage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FA8 RID: 8104 RVA: 0x0000D77B File Offset: 0x0000B97B
			public static implicit operator ServerSettingTranslator<T>.FromStorage(Func<int, T> A_0)
			{
				return DelegateSupport.ConvertDelegate<ServerSettingTranslator<T>.FromStorage>(A_0);
			}

			// Token: 0x06001FA9 RID: 8105 RVA: 0x0000D783 File Offset: 0x0000B983
			public static ServerSettingTranslator<T>.FromStorage operator +(ServerSettingTranslator<T>.FromStorage A_0, ServerSettingTranslator<T>.FromStorage A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ServerSettingTranslator<T>.FromStorage>();
			}

			// Token: 0x06001FAA RID: 8106 RVA: 0x0000D791 File Offset: 0x0000B991
			public static ServerSettingTranslator<T>.FromStorage operator -(ServerSettingTranslator<T>.FromStorage A_0, ServerSettingTranslator<T>.FromStorage A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ServerSettingTranslator<T>.FromStorage>();
				}
				return delegate2;
			}

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_Int32_0;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0;
		}

		// Token: 0x0200029B RID: 667
		public sealed class ToStorage : MulticastDelegate
		{
			// Token: 0x06001FAB RID: 8107 RVA: 0x0008FAEC File Offset: 0x0008DCEC
			// Note: this type is marked as 'beforefieldinit'.
			static ToStorage()
			{
				Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSettingTranslator<T>>.NativeClassPtr, "ToStorage"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr, 100664978);
				ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr, 100664979);
				ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr, 100664980);
				ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr, 100664981);
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x0008FB98 File Offset: 0x0008DD98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 864103, RefRangeEnd = 864104, XrefRangeStart = 864100, XrefRangeEnd = 864103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToStorage(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingTranslator<T>.ToStorage>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x0008FBF4 File Offset: 0x0008DDF4
			[CallerCount(0)]
			public unsafe int Invoke(T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001FAE RID: 8110 RVA: 0x0008FC78 File Offset: 0x0008DE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864104, XrefRangeEnd = 864108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0008FD24 File Offset: 0x0008DF24
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingTranslator<T>.ToStorage.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x0000D7A2 File Offset: 0x0000B9A2
			public ToStorage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x0000D7AB File Offset: 0x0000B9AB
			public static implicit operator ServerSettingTranslator<T>.ToStorage(Func<T, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ServerSettingTranslator<T>.ToStorage>(A_0);
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x0000D7B3 File Offset: 0x0000B9B3
			public static ServerSettingTranslator<T>.ToStorage operator +(ServerSettingTranslator<T>.ToStorage A_0, ServerSettingTranslator<T>.ToStorage A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ServerSettingTranslator<T>.ToStorage>();
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
			public static ServerSettingTranslator<T>.ToStorage operator -(ServerSettingTranslator<T>.ToStorage A_0, ServerSettingTranslator<T>.ToStorage A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ServerSettingTranslator<T>.ToStorage>();
				}
				return delegate2;
			}

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_0;

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
