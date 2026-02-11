using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000323 RID: 803
	public static class SerializationEventsCache : Object
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x000F93A4 File Offset: 0x000F75A4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventsCache()
		{
			Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEventsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr);
			SerializationEventsCache.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, "s_cache");
			SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, 100671002);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000F93FC File Offset: 0x000F75FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1384793, RefRangeEnd = 1384801, XrefRangeStart = 1384760, XrefRangeEnd = 1384793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationEvents GetSerializationEventsForType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEvents>(intPtr3) : null;
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x00010DAA File Offset: 0x0000EFAA
		public SerializationEventsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000F9440 File Offset: 0x000F7640
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x00010DB3 File Offset: 0x0000EFB3
		public unsafe static ConcurrentDictionary<Type, SerializationEvents> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationEventsCache.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, SerializationEvents>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationEventsCache.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0;

		// Token: 0x0200066E RID: 1646
		[ObfuscatedName("System.Runtime.Serialization.SerializationEventsCache+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005B60 RID: 23392 RVA: 0x0019FC38 File Offset: 0x0019DE38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr);
				SerializationEventsCache.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr, "<>9");
				SerializationEventsCache.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr, "<>9__1_0");
				SerializationEventsCache.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr, 100671005);
				SerializationEventsCache.__c.NativeMethodInfoPtr__GetSerializationEventsForType_b__1_0_Internal_SerializationEvents_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr, 100671006);
			}

			// Token: 0x06005B61 RID: 23393 RVA: 0x0019FCB4 File Offset: 0x0019DEB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEventsCache.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventsCache.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B62 RID: 23394 RVA: 0x0019FCF0 File Offset: 0x0019DEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384733, XrefRangeEnd = 1384760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializationEvents _GetSerializationEventsForType_b__1_0(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventsCache.__c.NativeMethodInfoPtr__GetSerializationEventsForType_b__1_0_Internal_SerializationEvents_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEvents>(intPtr3) : null;
				}
			}

			// Token: 0x06005B63 RID: 23395 RVA: 0x000211F8 File Offset: 0x0001F3F8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700176C RID: 5996
			// (get) Token: 0x06005B64 RID: 23396 RVA: 0x0019FD40 File Offset: 0x0019DF40
			// (set) Token: 0x06005B65 RID: 23397 RVA: 0x00021201 File Offset: 0x0001F401
			public unsafe static SerializationEventsCache.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializationEventsCache.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventsCache.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializationEventsCache.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176D RID: 5997
			// (get) Token: 0x06005B66 RID: 23398 RVA: 0x0019FD68 File Offset: 0x0019DF68
			// (set) Token: 0x06005B67 RID: 23399 RVA: 0x00021213 File Offset: 0x0001F413
			public unsafe static Func<Type, SerializationEvents> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializationEventsCache.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, SerializationEvents>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializationEventsCache.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A74 RID: 19060
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004A75 RID: 19061
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04004A76 RID: 19062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004A77 RID: 19063
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializationEventsForType_b__1_0_Internal_SerializationEvents_Type_0;
		}
	}
}
