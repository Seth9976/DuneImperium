using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DC RID: 476
	public sealed class UnwrapPromise<TResult> : Task<TResult>
	{
		// Token: 0x06001F66 RID: 8038 RVA: 0x000B4FD8 File Offset: 0x000B31D8
		// Note: this type is marked as 'beforefieldinit'.
		static UnwrapPromise()
		{
			Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnwrapPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr);
			UnwrapPromise<TResult>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_state");
			UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_lookForOce");
			UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668643);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668644);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668645);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668646);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668647);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668648);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668649);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100668650);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000B510C File Offset: 0x000B330C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361141, RefRangeEnd = 1361142, XrefRangeStart = 1361125, XrefRangeEnd = 1361141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnwrapPromise(Task outerTask, bool lookForOce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000B5168 File Offset: 0x000B3368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361142, XrefRangeEnd = 1361154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000B51AC File Offset: 0x000B33AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361156, RefRangeEnd = 1361157, XrefRangeStart = 1361154, XrefRangeEnd = 1361156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCore(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000B51F0 File Offset: 0x000B33F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361201, RefRangeEnd = 1361202, XrefRangeStart = 1361157, XrefRangeEnd = 1361201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCoreAsync(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000B5234 File Offset: 0x000B3434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361213, RefRangeEnd = 1361215, XrefRangeStart = 1361202, XrefRangeEnd = 1361213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCompletedOuterTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000B5278 File Offset: 0x000B3478
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1361254, RefRangeEnd = 1361258, XrefRangeStart = 1361215, XrefRangeEnd = 1361254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetFromTask(Task task, bool lookForOce)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000B52D4 File Offset: 0x000B34D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361258, XrefRangeEnd = 1361261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInnerTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x000B5318 File Offset: 0x000B3518
		public unsafe bool InvokeMayRunArbitraryCode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0000A2F9 File Offset: 0x000084F9
		public UnwrapPromise(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x000B5354 File Offset: 0x000B3554
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000A302 File Offset: 0x00008502
		public unsafe byte _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x000B537C File Offset: 0x000B357C
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000A31D File Offset: 0x0000851D
		public unsafe bool _lookForOce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce)) = value;
			}
		}

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeFieldInfoPtr__lookForOce;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0200063F RID: 1599
		[ObfuscatedName("System.Threading.Tasks.UnwrapPromise`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005974 RID: 22900 RVA: 0x00199FF8 File Offset: 0x001981F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr);
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9");
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9__8_0");
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100668652);
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100668653);
			}

			// Token: 0x06005975 RID: 22901 RVA: 0x0019A0B0 File Offset: 0x001982B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005976 RID: 22902 RVA: 0x0019A0EC File Offset: 0x001982EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361121, XrefRangeEnd = 1361125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCoreAsync_b__8_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005977 RID: 22903 RVA: 0x00020050 File Offset: 0x0001E250
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016CE RID: 5838
			// (get) Token: 0x06005978 RID: 22904 RVA: 0x0019A130 File Offset: 0x00198330
			// (set) Token: 0x06005979 RID: 22905 RVA: 0x00020059 File Offset: 0x0001E259
			public unsafe static UnwrapPromise<TResult>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnwrapPromise<TResult>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016CF RID: 5839
			// (get) Token: 0x0600597A RID: 22906 RVA: 0x0019A158 File Offset: 0x00198358
			// (set) Token: 0x0600597B RID: 22907 RVA: 0x0002006B File Offset: 0x0001E26B
			public unsafe static WaitCallback __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004959 RID: 18777
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400495A RID: 18778
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400495B RID: 18779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400495C RID: 18780
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0;
		}
	}
}
