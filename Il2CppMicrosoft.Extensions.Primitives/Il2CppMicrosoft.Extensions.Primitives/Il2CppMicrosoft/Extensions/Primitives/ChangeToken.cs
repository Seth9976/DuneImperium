using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Primitives
{
	// Token: 0x02000008 RID: 8
	public static class ChangeToken : Object
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002168 File Offset: 0x00000368
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeToken()
		{
			Il2CppClassPointerStore<ChangeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Primitives.dll", "Microsoft.Extensions.Primitives", "ChangeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeToken>.NativeClassPtr);
			ChangeToken.NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_Func_1_IChangeToken_Action_1_TState_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000266C File Offset: 0x0000086C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273020, RefRangeEnd = 1273021, XrefRangeStart = 1273014, XrefRangeEnd = 1273020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable OnChange<TState>(Func<IChangeToken> changeTokenProducer, Action<TState> changeTokenConsumer, TState state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeTokenProducer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeTokenConsumer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TState).IsValueType)
			{
				TState tstate = state;
				intPtr = ((tstate is string) ? IL2CPP.ManagedStringToIl2Cpp(tstate as string) : IL2CPP.Il2CppObjectBaseToPtr(tstate as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref state;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChangeToken.MethodInfoStoreGeneric_OnChange_Public_Static_IDisposable_Func_1_IChangeToken_Action_1_TState_TState_0<TState>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr4) : null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021A1 File Offset: 0x000003A1
		public ChangeToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_Func_1_IChangeToken_Action_1_TState_TState_0;

		// Token: 0x0200000C RID: 12
		public sealed class ChangeTokenRegistration<TState> : Object
		{
			// Token: 0x06000028 RID: 40 RVA: 0x0000293C File Offset: 0x00000B3C
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeTokenRegistration()
			{
				Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeToken>.NativeClassPtr, "ChangeTokenRegistration`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr);
				ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenProducer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "_changeTokenProducer");
				ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "_changeTokenConsumer");
				ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "_state");
				ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "_disposable");
				ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposedSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "_disposedSentinel");
				ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_IChangeToken_Action_1_TState_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, 100663305);
				ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_OnChangeTokenFired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, 100663306);
				ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_RegisterChangeTokenCallback_Private_Void_IChangeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, 100663307);
				ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_SetDisposable_Private_Void_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, 100663308);
				ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, 100663309);
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002A6C File Offset: 0x00000C6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272961, RefRangeEnd = 1272962, XrefRangeStart = 1272955, XrefRangeEnd = 1272961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeTokenRegistration(Func<IChangeToken> changeTokenProducer, Action<TState> changeTokenConsumer, TState state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeTokenProducer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeTokenConsumer);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TState).IsValueType)
				{
					TState tstate = state;
					intPtr = ((tstate is string) ? IL2CPP.ManagedStringToIl2Cpp(tstate as string) : IL2CPP.Il2CppObjectBaseToPtr(tstate as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref state;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_IChangeToken_Action_1_TState_TState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00002B14 File Offset: 0x00000D14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272965, RefRangeEnd = 1272966, XrefRangeStart = 1272962, XrefRangeEnd = 1272965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnChangeTokenFired()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_OnChangeTokenFired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00002B48 File Offset: 0x00000D48
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1272991, RefRangeEnd = 1272994, XrefRangeStart = 1272966, XrefRangeEnd = 1272991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RegisterChangeTokenCallback(IChangeToken token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_RegisterChangeTokenCallback_Private_Void_IChangeToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002B8C File Offset: 0x00000D8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1273006, RefRangeEnd = 1273007, XrefRangeStart = 1272994, XrefRangeEnd = 1273006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetDisposable(IDisposable disposable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(disposable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_SetDisposable_Private_Void_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00002BD0 File Offset: 0x00000DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273007, XrefRangeEnd = 1273014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x000021BC File Offset: 0x000003BC
			public ChangeTokenRegistration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00002C04 File Offset: 0x00000E04
			// (set) Token: 0x06000030 RID: 48 RVA: 0x000021C5 File Offset: 0x000003C5
			public unsafe Func<IChangeToken> _changeTokenProducer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenProducer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IChangeToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenProducer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00002C34 File Offset: 0x00000E34
			// (set) Token: 0x06000032 RID: 50 RVA: 0x000021E4 File Offset: 0x000003E4
			public unsafe Action<TState> _changeTokenConsumer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenConsumer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__changeTokenConsumer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00002C64 File Offset: 0x00000E64
			// (set) Token: 0x06000034 RID: 52 RVA: 0x00002C8C File Offset: 0x00000E8C
			public unsafe TState _state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__state);
					return IL2CPP.PointerToValueGeneric<TState>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__state);
					Type typeFromHandle = typeof(TState);
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

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002D34 File Offset: 0x00000F34
			// (set) Token: 0x06000036 RID: 54 RVA: 0x00002203 File Offset: 0x00000403
			public unsafe IDisposable _disposable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00002D64 File Offset: 0x00000F64
			// (set) Token: 0x06000038 RID: 56 RVA: 0x00002222 File Offset: 0x00000422
			public unsafe static ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable _disposedSentinel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposedSentinel, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChangeToken.ChangeTokenRegistration<TState>.NativeFieldInfoPtr__disposedSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000022 RID: 34
			private static readonly IntPtr NativeFieldInfoPtr__changeTokenProducer;

			// Token: 0x04000023 RID: 35
			private static readonly IntPtr NativeFieldInfoPtr__changeTokenConsumer;

			// Token: 0x04000024 RID: 36
			private static readonly IntPtr NativeFieldInfoPtr__state;

			// Token: 0x04000025 RID: 37
			private static readonly IntPtr NativeFieldInfoPtr__disposable;

			// Token: 0x04000026 RID: 38
			private static readonly IntPtr NativeFieldInfoPtr__disposedSentinel;

			// Token: 0x04000027 RID: 39
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_IChangeToken_Action_1_TState_TState_0;

			// Token: 0x04000028 RID: 40
			private static readonly IntPtr NativeMethodInfoPtr_OnChangeTokenFired_Private_Void_0;

			// Token: 0x04000029 RID: 41
			private static readonly IntPtr NativeMethodInfoPtr_RegisterChangeTokenCallback_Private_Void_IChangeToken_0;

			// Token: 0x0400002A RID: 42
			private static readonly IntPtr NativeMethodInfoPtr_SetDisposable_Private_Void_IDisposable_0;

			// Token: 0x0400002B RID: 43
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0200000E RID: 14
			public sealed class NoopDisposable : Object
			{
				// Token: 0x0600003A RID: 58 RVA: 0x00002DE0 File Offset: 0x00000FE0
				// Note: this type is marked as 'beforefieldinit'.
				static NoopDisposable()
				{
					Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "NoopDisposable"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>.NativeClassPtr);
					ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>.NativeClassPtr, 100663311);
					ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>.NativeClassPtr, 100663312);
				}

				// Token: 0x0600003B RID: 59 RVA: 0x00002E70 File Offset: 0x00001070
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600003C RID: 60 RVA: 0x00002EA4 File Offset: 0x000010A4
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NoopDisposable()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.NoopDisposable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600003D RID: 61 RVA: 0x00002234 File Offset: 0x00000434
				public NoopDisposable(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400002D RID: 45
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x0400002E RID: 46
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x0200000F RID: 15
			[ObfuscatedName("Microsoft.Extensions.Primitives.ChangeToken+ChangeTokenRegistration`1+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0600003E RID: 62 RVA: 0x00002EE0 File Offset: 0x000010E0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr);
					ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr, "<>9");
					ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr, "<>9__7_0");
					ChangeToken.ChangeTokenRegistration<TState>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr, 100663314);
					ChangeToken.ChangeTokenRegistration<TState>.__c.NativeMethodInfoPtr__RegisterChangeTokenCallback_b__7_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr, 100663315);
				}

				// Token: 0x0600003F RID: 63 RVA: 0x00002F98 File Offset: 0x00001198
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeToken.ChangeTokenRegistration<TState>.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000040 RID: 64 RVA: 0x00002FD4 File Offset: 0x000011D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272944, XrefRangeEnd = 1272955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _RegisterChangeTokenCallback_b__7_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeMethodInfoPtr__RegisterChangeTokenCallback_b__7_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000041 RID: 65 RVA: 0x0000223D File Offset: 0x0000043D
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700000C RID: 12
				// (get) Token: 0x06000042 RID: 66 RVA: 0x00003018 File Offset: 0x00001218
				// (set) Token: 0x06000043 RID: 67 RVA: 0x00002246 File Offset: 0x00000446
				public unsafe static ChangeToken.ChangeTokenRegistration<TState>.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeToken.ChangeTokenRegistration<TState>.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700000D RID: 13
				// (get) Token: 0x06000044 RID: 68 RVA: 0x00003040 File Offset: 0x00001240
				// (set) Token: 0x06000045 RID: 69 RVA: 0x00002258 File Offset: 0x00000458
				public unsafe static Action<Object> __9__7_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ChangeToken.ChangeTokenRegistration<TState>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400002F RID: 47
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000030 RID: 48
				private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

				// Token: 0x04000031 RID: 49
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000032 RID: 50
				private static readonly IntPtr NativeMethodInfoPtr__RegisterChangeTokenCallback_b__7_0_Internal_Void_Object_0;
			}
		}

		// Token: 0x0200000D RID: 13
		private sealed class MethodInfoStoreGeneric_OnChange_Public_Static_IDisposable_Func_1_IChangeToken_Action_1_TState_TState_0<TState>
		{
			// Token: 0x0400002C RID: 44
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ChangeToken.NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_Func_1_IChangeToken_Action_1_TState_TState_0, Il2CppClassPointerStore<ChangeToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
