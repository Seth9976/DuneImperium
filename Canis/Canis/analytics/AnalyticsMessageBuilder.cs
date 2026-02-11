using System;
using System.Runtime.InteropServices;
using analytics;
using canis.archetypes;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.analytics
{
	// Token: 0x02000162 RID: 354
	[Serializable]
	public class AnalyticsMessageBuilder : Object
	{
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0005A2A4 File Offset: 0x000584A4
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsMessageBuilder()
		{
			Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.analytics", "AnalyticsMessageBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr);
			AnalyticsMessageBuilder.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, "EventName");
			AnalyticsMessageBuilder.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, "Data");
			AnalyticsMessageBuilder.NativeMethodInfoPtr_GetAnalyticsName_Private_IEnumerable_1_ValueTuple_2_String_String_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, 100666547);
			AnalyticsMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_New_IAnalyticsMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, 100666548);
			AnalyticsMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, 100666549);
			AnalyticsMessageBuilder.NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, 100666550);
			AnalyticsMessageBuilder.NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, 100666551);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0005A360 File Offset: 0x00058560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 578675, RefRangeEnd = 578676, XrefRangeStart = 578668, XrefRangeEnd = 578675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, string>> GetAnalyticsName(string key, Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder.NativeMethodInfoPtr_GetAnalyticsName_Private_IEnumerable_1_ValueTuple_2_String_String_String_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, string>>>(intPtr3) : null;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0005A3C4 File Offset: 0x000585C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578676, XrefRangeEnd = 578708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAnalyticsMessage Build(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsMessageBuilder.NativeMethodInfoPtr_Build_Public_Virtual_New_IAnalyticsMessage_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAnalyticsMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0005A420 File Offset: 0x00058620
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 578717, RefRangeEnd = 578731, XrefRangeStart = 578708, XrefRangeEnd = 578717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsMessageBuilder(string eventName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0005A46C File Offset: 0x0005866C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 578739, RefRangeEnd = 578746, XrefRangeStart = 578731, XrefRangeEnd = 578739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsMessageBuilder AddData(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder.NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnalyticsMessageBuilder>(intPtr3) : null;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0005A4D0 File Offset: 0x000586D0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 578780, RefRangeEnd = 578795, XrefRangeStart = 578746, XrefRangeEnd = 578780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsMessageBuilder AddData([Optional] Il2CppReferenceArray<ValueTuple<string, Object>> data)
		{
			if (data == null)
			{
				data = new Il2CppStructArray<ValueTuple<string, Object>>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder.NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnalyticsMessageBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00008228 File Offset: 0x00006428
		public AnalyticsMessageBuilder AddData(params ValueTuple<string, Object>[] data)
		{
			return this.AddData(new Il2CppReferenceArray<ValueTuple<string, Object>>(data));
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00008236 File Offset: 0x00006436
		public AnalyticsMessageBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0005A530 File Offset: 0x00058730
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x0000823F File Offset: 0x0000643F
		public unsafe string EventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder.NativeFieldInfoPtr_EventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder.NativeFieldInfoPtr_EventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0005A558 File Offset: 0x00058758
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x0000825E File Offset: 0x0000645E
		public unsafe Dictionary<string, Object> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_EventName;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalyticsName_Private_IEnumerable_1_ValueTuple_2_String_String_String_Entity_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_New_IAnalyticsMessage_Match_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_String_Object_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_AnalyticsMessageBuilder_Il2CppReferenceArray_1_ValueTuple_2_String_Object_0;

		// Token: 0x020003A1 RID: 929
		[ObfuscatedName("Canis.analytics.AnalyticsMessageBuilder+<GetAnalyticsName>d__2")]
		public sealed class _GetAnalyticsName_d__2 : Object
		{
			// Token: 0x06002698 RID: 9880 RVA: 0x000A9ED8 File Offset: 0x000A80D8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAnalyticsName_d__2()
			{
				Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsMessageBuilder>.NativeClassPtr, "<GetAnalyticsName>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<>1__state");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<>2__current");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<>l__initialThreadId");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "entity");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<>3__entity");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "key");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<>3__key");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr__archetype_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, "<archetype>5__2");
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666552);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666553);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666554);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666555);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666556);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666557);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666558);
				AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr, 100666559);
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x000AA044 File Offset: 0x000A8244
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAnalyticsName_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsMessageBuilder._GetAnalyticsName_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600269A RID: 9882 RVA: 0x000AA08C File Offset: 0x000A828C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600269B RID: 9883 RVA: 0x000AA0C0 File Offset: 0x000A82C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578641, XrefRangeEnd = 578651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x0600269C RID: 9884 RVA: 0x000AA0FC File Offset: 0x000A82FC
			public unsafe ValueTuple<string, string> prop_ValueTuple_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, string>(intPtr);
				}
			}

			// Token: 0x0600269D RID: 9885 RVA: 0x000AA134 File Offset: 0x000A8334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578651, XrefRangeEnd = 578656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x0600269E RID: 9886 RVA: 0x000AA168 File Offset: 0x000A8368
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578656, XrefRangeEnd = 578659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600269F RID: 9887 RVA: 0x000AA1A8 File Offset: 0x000A83A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578659, XrefRangeEnd = 578668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, string>>>(intPtr3) : null;
			}

			// Token: 0x060026A0 RID: 9888 RVA: 0x000AA1E8 File Offset: 0x000A83E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060026A1 RID: 9889 RVA: 0x0001260C File Offset: 0x0001080C
			public _GetAnalyticsName_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000AA228 File Offset: 0x000A8428
			// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00012615 File Offset: 0x00010815
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000AA250 File Offset: 0x000A8450
			// (set) Token: 0x060026A5 RID: 9893 RVA: 0x00012630 File Offset: 0x00010830
			public ValueTuple<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000AA280 File Offset: 0x000A8480
			// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0001265E File Offset: 0x0001085E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000AA2A8 File Offset: 0x000A84A8
			// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00012679 File Offset: 0x00010879
			public unsafe Entity entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x060026AA RID: 9898 RVA: 0x000AA2D8 File Offset: 0x000A84D8
			// (set) Token: 0x060026AB RID: 9899 RVA: 0x00012698 File Offset: 0x00010898
			public unsafe Entity __3__entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x060026AC RID: 9900 RVA: 0x000AA308 File Offset: 0x000A8508
			// (set) Token: 0x060026AD RID: 9901 RVA: 0x000126B7 File Offset: 0x000108B7
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x000AA330 File Offset: 0x000A8530
			// (set) Token: 0x060026AF RID: 9903 RVA: 0x000126D6 File Offset: 0x000108D6
			public unsafe string __3__key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr___3__key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000AA358 File Offset: 0x000A8558
			// (set) Token: 0x060026B1 RID: 9905 RVA: 0x000126F5 File Offset: 0x000108F5
			public unsafe Archetype _archetype_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr__archetype_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsMessageBuilder._GetAnalyticsName_d__2.NativeFieldInfoPtr__archetype_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr___3__entity;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeFieldInfoPtr___3__key;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeFieldInfoPtr__archetype_5__2;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001820 RID: 6176
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_String_0;

			// Token: 0x04001821 RID: 6177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001822 RID: 6178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001823 RID: 6179
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_String_0;

			// Token: 0x04001824 RID: 6180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
