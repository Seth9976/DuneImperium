using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000031 RID: 49
	public class InverseLerpOverTime : Command
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0000C190 File Offset: 0x0000A390
		// Note: this type is marked as 'beforefieldinit'.
		static InverseLerpOverTime()
		{
			Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "InverseLerpOverTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr);
			InverseLerpOverTime.NativeFieldInfoPtr_DurationSecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, "DurationSecs");
			InverseLerpOverTime.NativeFieldInfoPtr_getTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, "getTime");
			InverseLerpOverTime.NativeFieldInfoPtr_onTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, "onTick");
			InverseLerpOverTime.NativeMethodInfoPtr__ctor_Public_Void_Single_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, 100663812);
			InverseLerpOverTime.NativeMethodInfoPtr__ctor_Public_Void_Single_Func_1_Single_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, 100663813);
			InverseLerpOverTime.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, 100663814);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000C238 File Offset: 0x0000A438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209650, XrefRangeEnd = 1209672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InverseLerpOverTime(float durationSecs, Action<float> onTick)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationSecs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTick);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime.NativeMethodInfoPtr__ctor_Public_Void_Single_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C294 File Offset: 0x0000A494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1209679, RefRangeEnd = 1209680, XrefRangeStart = 1209672, XrefRangeEnd = 1209679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InverseLerpOverTime(float durationSecs, Func<float> getTime, Action<float> onTick)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationSecs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getTime);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTick);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime.NativeMethodInfoPtr__ctor_Public_Void_Single_Func_1_Single_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000C300 File Offset: 0x0000A500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209680, XrefRangeEnd = 1209685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InverseLerpOverTime.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002C39 File Offset: 0x00000E39
		public InverseLerpOverTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000C34C File Offset: 0x0000A54C
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002C42 File Offset: 0x00000E42
		public unsafe float DurationSecs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_DurationSecs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_DurationSecs)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000C374 File Offset: 0x0000A574
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002C5D File Offset: 0x00000E5D
		public unsafe Func<float> getTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_getTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_getTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002C7C File Offset: 0x00000E7C
		public unsafe Action<float> onTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_onTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime.NativeFieldInfoPtr_onTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_DurationSecs;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_getTime;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_onTick;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Action_1_Single_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Func_1_Single_Action_1_Single_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000092 RID: 146
		[ObfuscatedName("dwd.core.commands.InverseLerpOverTime+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600056D RID: 1389 RVA: 0x00017E60 File Offset: 0x00016060
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr);
				InverseLerpOverTime.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr, "<>9");
				InverseLerpOverTime.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr, "<>9__3_0");
				InverseLerpOverTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr, 100663816);
				InverseLerpOverTime.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr, 100663817);
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00017EDC File Offset: 0x000160DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InverseLerpOverTime.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00017F18 File Offset: 0x00016118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209641, XrefRangeEnd = 1209642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float __ctor_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00004640 File Offset: 0x00002840
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000571 RID: 1393 RVA: 0x00017F54 File Offset: 0x00016154
			// (set) Token: 0x06000572 RID: 1394 RVA: 0x00004649 File Offset: 0x00002849
			public unsafe static InverseLerpOverTime.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InverseLerpOverTime.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InverseLerpOverTime.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InverseLerpOverTime.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x00017F7C File Offset: 0x0001617C
			// (set) Token: 0x06000574 RID: 1396 RVA: 0x0000465B File Offset: 0x0000285B
			public unsafe static Func<float> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InverseLerpOverTime.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InverseLerpOverTime.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_Single_0;
		}

		// Token: 0x02000093 RID: 147
		[ObfuscatedName("dwd.core.commands.InverseLerpOverTime+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06000575 RID: 1397 RVA: 0x00017FA4 File Offset: 0x000161A4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InverseLerpOverTime>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr);
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<>1__state");
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<>2__current");
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<>4__this");
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__startTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<startTime>5__2");
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__endTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<endTime>5__3");
				InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__currentTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, "<currentTime>5__4");
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663818);
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663819);
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663820);
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663821);
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663822);
				InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr, 100663823);
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x000180C0 File Offset: 0x000162C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InverseLerpOverTime._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00018108 File Offset: 0x00016308
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x0001813C File Offset: 0x0001633C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209642, XrefRangeEnd = 1209645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x00018178 File Offset: 0x00016378
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x000181B8 File Offset: 0x000163B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209645, XrefRangeEnd = 1209650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x000181EC File Offset: 0x000163EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InverseLerpOverTime._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0000466D File Offset: 0x0000286D
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001822C File Offset: 0x0001642C
			// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004676 File Offset: 0x00002876
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x00018254 File Offset: 0x00016454
			// (set) Token: 0x06000580 RID: 1408 RVA: 0x00004691 File Offset: 0x00002891
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000581 RID: 1409 RVA: 0x00018284 File Offset: 0x00016484
			// (set) Token: 0x06000582 RID: 1410 RVA: 0x000046B0 File Offset: 0x000028B0
			public unsafe InverseLerpOverTime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InverseLerpOverTime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x000182B4 File Offset: 0x000164B4
			// (set) Token: 0x06000584 RID: 1412 RVA: 0x000046CF File Offset: 0x000028CF
			public unsafe float _startTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__startTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__startTime_5__2)) = value;
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000585 RID: 1413 RVA: 0x000182DC File Offset: 0x000164DC
			// (set) Token: 0x06000586 RID: 1414 RVA: 0x000046EA File Offset: 0x000028EA
			public unsafe float _endTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__endTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__endTime_5__3)) = value;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000587 RID: 1415 RVA: 0x00018304 File Offset: 0x00016504
			// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004705 File Offset: 0x00002905
			public unsafe float _currentTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__currentTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InverseLerpOverTime._execute_d__5.NativeFieldInfoPtr__currentTime_5__4)) = value;
				}
			}

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__2;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr__endTime_5__3;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__4;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
