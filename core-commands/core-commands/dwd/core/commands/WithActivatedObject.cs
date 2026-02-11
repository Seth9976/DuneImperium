using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.commands
{
	// Token: 0x02000023 RID: 35
	public class WithActivatedObject : Command
	{
		// Token: 0x0600015F RID: 351 RVA: 0x0000A5DC File Offset: 0x000087DC
		// Note: this type is marked as 'beforefieldinit'.
		static WithActivatedObject()
		{
			Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "WithActivatedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr);
			WithActivatedObject.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, "command");
			WithActivatedObject.NativeFieldInfoPtr_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, "spinner");
			WithActivatedObject.NativeFieldInfoPtr_after = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, "after");
			WithActivatedObject.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, 100663703);
			WithActivatedObject.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, 100663704);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000A670 File Offset: 0x00008870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209220, XrefRangeEnd = 1209227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WithActivatedObject(IEnumerator command, GameObject spinner, float after)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000A6DC File Offset: 0x000088DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209227, XrefRangeEnd = 1209232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WithActivatedObject.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002881 File Offset: 0x00000A81
		public WithActivatedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000A728 File Offset: 0x00008928
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000288A File Offset: 0x00000A8A
		public unsafe IEnumerator command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000A758 File Offset: 0x00008958
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe GameObject spinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_spinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A788 File Offset: 0x00008988
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000028C8 File Offset: 0x00000AC8
		public unsafe float after
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_after);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject.NativeFieldInfoPtr_after)) = value;
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_spinner;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_after;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_GameObject_Single_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("dwd.core.commands.WithActivatedObject+<execute>d__4")]
		public sealed class _execute_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x060004BE RID: 1214 RVA: 0x00015BA0 File Offset: 0x00013DA0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WithActivatedObject>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr);
				WithActivatedObject._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, "<>1__state");
				WithActivatedObject._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, "<>2__current");
				WithActivatedObject._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, "<>4__this");
				WithActivatedObject._execute_d__4.NativeFieldInfoPtr__startTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, "<startTime>5__2");
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663705);
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663706);
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663707);
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663708);
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663709);
				WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr, 100663710);
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x00015C94 File Offset: 0x00013E94
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WithActivatedObject._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x00015CDC File Offset: 0x00013EDC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x00015D10 File Offset: 0x00013F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209202, XrefRangeEnd = 1209215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00015D4C File Offset: 0x00013F4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x00015D8C File Offset: 0x00013F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209215, XrefRangeEnd = 1209220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00015DC0 File Offset: 0x00013FC0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithActivatedObject._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x000040FA File Offset: 0x000022FA
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00015E00 File Offset: 0x00014000
			// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00004103 File Offset: 0x00002303
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00015E28 File Offset: 0x00014028
			// (set) Token: 0x060004C9 RID: 1225 RVA: 0x0000411E File Offset: 0x0000231E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060004CA RID: 1226 RVA: 0x00015E58 File Offset: 0x00014058
			// (set) Token: 0x060004CB RID: 1227 RVA: 0x0000413D File Offset: 0x0000233D
			public unsafe WithActivatedObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WithActivatedObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x00015E88 File Offset: 0x00014088
			// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000415C File Offset: 0x0000235C
			public unsafe float _startTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr__startTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithActivatedObject._execute_d__4.NativeFieldInfoPtr__startTime_5__2)) = value;
				}
			}

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__2;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
