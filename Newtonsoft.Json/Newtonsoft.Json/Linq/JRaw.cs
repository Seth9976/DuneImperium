using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BE RID: 190
	public class JRaw : JValue
	{
		// Token: 0x06001158 RID: 4440 RVA: 0x00061534 File Offset: 0x0005F734
		// Note: this type is marked as 'beforefieldinit'.
		static JRaw()
		{
			Il2CppClassPointerStore<JRaw>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JRaw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JRaw>.NativeClassPtr);
			JRaw.NativeMethodInfoPtr_CreateAsync_Public_Static_Task_1_JRaw_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666506);
			JRaw.NativeMethodInfoPtr__ctor_Public_Void_JRaw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666507);
			JRaw.NativeMethodInfoPtr__ctor_Internal_Void_JRaw_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666508);
			JRaw.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666509);
			JRaw.NativeMethodInfoPtr_Create_Public_Static_JRaw_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666510);
			JRaw.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw>.NativeClassPtr, 100666511);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000615DC File Offset: 0x0005F7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759210, XrefRangeEnd = 759225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw.NativeMethodInfoPtr_CreateAsync_Public_Static_Task_1_JRaw_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JRaw>>(intPtr3) : null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00061638 File Offset: 0x0005F838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759225, XrefRangeEnd = 759226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JRaw(JRaw other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JRaw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw.NativeMethodInfoPtr__ctor_Public_Void_JRaw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00061684 File Offset: 0x0005F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759226, XrefRangeEnd = 759227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JRaw(JRaw other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JRaw>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw.NativeMethodInfoPtr__ctor_Internal_Void_JRaw_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000616E4 File Offset: 0x0005F8E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 759228, RefRangeEnd = 759230, XrefRangeStart = 759227, XrefRangeEnd = 759228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JRaw(Object rawJson)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JRaw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawJson);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00061730 File Offset: 0x0005F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759230, XrefRangeEnd = 759257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JRaw Create(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw.NativeMethodInfoPtr_Create_Public_Static_JRaw_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JRaw>(intPtr3) : null;
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00061774 File Offset: 0x0005F974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759257, XrefRangeEnd = 759261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JToken CloneToken(JsonCloneSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JRaw.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000078F1 File Offset: 0x00005AF1
		public JRaw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_CreateAsync_Public_Static_Task_1_JRaw_JsonReader_CancellationToken_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JRaw_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JRaw_JsonCloneSettings_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_JRaw_JsonReader_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0;

		// Token: 0x02000208 RID: 520
		[ObfuscatedName("Newtonsoft.Json.Linq.JRaw+<CreateAsync>d__0")]
		public sealed class _CreateAsync_d__0 : ValueType
		{
			// Token: 0x060020AC RID: 8364 RVA: 0x000931F0 File Offset: 0x000913F0
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateAsync_d__0()
			{
				Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JRaw>.NativeClassPtr, "<CreateAsync>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr);
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "<>1__state");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "<>t__builder");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "reader");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "cancellationToken");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr__sw_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "<sw>5__2");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr__jsonWriter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "<jsonWriter>5__3");
				JRaw._CreateAsync_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, "<>u__1");
				JRaw._CreateAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, 100666512);
				JRaw._CreateAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr, 100666513);
			}

			// Token: 0x060020AD RID: 8365 RVA: 0x000932D0 File Offset: 0x000914D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759169, XrefRangeEnd = 759204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw._CreateAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x00093308 File Offset: 0x00091508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759204, XrefRangeEnd = 759210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JRaw._CreateAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x000106B7 File Offset: 0x0000E8B7
			public _CreateAsync_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020B0 RID: 8368 RVA: 0x000106C0 File Offset: 0x0000E8C0
			public _CreateAsync_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JRaw._CreateAsync_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00093350 File Offset: 0x00091550
			// (set) Token: 0x060020B2 RID: 8370 RVA: 0x000106D2 File Offset: 0x0000E8D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00093378 File Offset: 0x00091578
			// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000106ED File Offset: 0x0000E8ED
			public AsyncTaskMethodBuilder<JRaw> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JRaw>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JRaw>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JRaw>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000933A8 File Offset: 0x000915A8
			// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0001071B File Offset: 0x0000E91B
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000933D8 File Offset: 0x000915D8
			// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0001073A File Offset: 0x0000E93A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x060020B9 RID: 8377 RVA: 0x00093408 File Offset: 0x00091608
			// (set) Token: 0x060020BA RID: 8378 RVA: 0x00010768 File Offset: 0x0000E968
			public unsafe StringWriter _sw_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr__sw_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr__sw_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x060020BB RID: 8379 RVA: 0x00093438 File Offset: 0x00091638
			// (set) Token: 0x060020BC RID: 8380 RVA: 0x00010787 File Offset: 0x0000E987
			public unsafe JsonTextWriter _jsonWriter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr__jsonWriter_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr__jsonWriter_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x060020BD RID: 8381 RVA: 0x00093468 File Offset: 0x00091668
			// (set) Token: 0x060020BE RID: 8382 RVA: 0x000107A6 File Offset: 0x0000E9A6
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JRaw._CreateAsync_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeFieldInfoPtr__sw_5__2;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeFieldInfoPtr__jsonWriter_5__3;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
