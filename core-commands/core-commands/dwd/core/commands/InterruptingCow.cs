using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x0200001B RID: 27
	public sealed class InterruptingCow : Command
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00009108 File Offset: 0x00007308
		// Note: this type is marked as 'beforefieldinit'.
		static InterruptingCow()
		{
			Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "InterruptingCow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr);
			InterruptingCow.NativeFieldInfoPtr__toInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, "_toInterrupt");
			InterruptingCow.NativeFieldInfoPtr__interruptAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, "_interruptAfter");
			InterruptingCow.NativeMethodInfoPtr__ctor_Public_Void_InterruptableCommand_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, 100663561);
			InterruptingCow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, 100663562);
			InterruptingCow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, 100663563);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000919C File Offset: 0x0000739C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1208125, RefRangeEnd = 1208127, XrefRangeStart = 1208125, XrefRangeEnd = 1208127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterruptingCow(InterruptableCommand toInterrupt, float interruptAfter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toInterrupt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow.NativeMethodInfoPtr__ctor_Public_Void_InterruptableCommand_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000091F8 File Offset: 0x000073F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208182, XrefRangeEnd = 1208187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00009238 File Offset: 0x00007438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208187, XrefRangeEnd = 1208188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000266D File Offset: 0x0000086D
		public InterruptingCow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00009270 File Offset: 0x00007470
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002676 File Offset: 0x00000876
		public unsafe InterruptableCommand _toInterrupt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow.NativeFieldInfoPtr__toInterrupt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow.NativeFieldInfoPtr__toInterrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000092A0 File Offset: 0x000074A0
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002695 File Offset: 0x00000895
		public unsafe float _interruptAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow.NativeFieldInfoPtr__interruptAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow.NativeFieldInfoPtr__interruptAfter)) = value;
			}
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr__toInterrupt;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr__interruptAfter;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InterruptableCommand_Single_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("dwd.core.commands.InterruptingCow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06000389 RID: 905 RVA: 0x00011BA4 File Offset: 0x0000FDA4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InterruptingCow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr);
				InterruptingCow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, "<>1__state");
				InterruptingCow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, "<>2__current");
				InterruptingCow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, "<>4__this");
				InterruptingCow._execute_d__3.NativeFieldInfoPtr__endTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, "<endTime>5__2");
				InterruptingCow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663564);
				InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663565);
				InterruptingCow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663566);
				InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663567);
				InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663568);
				InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr, 100663569);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00011C98 File Offset: 0x0000FE98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterruptingCow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00011CE0 File Offset: 0x0000FEE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00011D14 File Offset: 0x0000FF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208169, XrefRangeEnd = 1208177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600038D RID: 909 RVA: 0x00011D50 File Offset: 0x0000FF50
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00011D90 File Offset: 0x0000FF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208177, XrefRangeEnd = 1208182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x0600038F RID: 911 RVA: 0x00011DC4 File Offset: 0x0000FFC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterruptingCow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000390 RID: 912 RVA: 0x000038B1 File Offset: 0x00001AB1
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000391 RID: 913 RVA: 0x00011E04 File Offset: 0x00010004
			// (set) Token: 0x06000392 RID: 914 RVA: 0x000038BA File Offset: 0x00001ABA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000393 RID: 915 RVA: 0x00011E2C File Offset: 0x0001002C
			// (set) Token: 0x06000394 RID: 916 RVA: 0x000038D5 File Offset: 0x00001AD5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000395 RID: 917 RVA: 0x00011E5C File Offset: 0x0001005C
			// (set) Token: 0x06000396 RID: 918 RVA: 0x000038F4 File Offset: 0x00001AF4
			public unsafe InterruptingCow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptingCow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000397 RID: 919 RVA: 0x00011E8C File Offset: 0x0001008C
			// (set) Token: 0x06000398 RID: 920 RVA: 0x00003913 File Offset: 0x00001B13
			public unsafe float _endTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr__endTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterruptingCow._execute_d__3.NativeFieldInfoPtr__endTime_5__2)) = value;
				}
			}

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeFieldInfoPtr__endTime_5__2;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
