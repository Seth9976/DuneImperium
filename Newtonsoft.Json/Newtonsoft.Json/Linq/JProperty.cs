using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BB RID: 187
	public class JProperty : JContainer
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x0005FB14 File Offset: 0x0005DD14
		// Note: this type is marked as 'beforefieldinit'.
		static JProperty()
		{
			Il2CppClassPointerStore<JProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JProperty>.NativeClassPtr);
			JProperty.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty>.NativeClassPtr, "_content");
			JProperty.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty>.NativeClassPtr, "_name");
			JProperty.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666420);
			JProperty.NativeMethodInfoPtr_WriteToAsync_Private_Task_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666421);
			JProperty.NativeMethodInfoPtr_WriteValueAsync_Private_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666422);
			JProperty.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666423);
			JProperty.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666424);
			JProperty.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666425);
			JProperty.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666426);
			JProperty.NativeMethodInfoPtr_get_Value_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666427);
			JProperty.NativeMethodInfoPtr_set_Value_Public_set_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666428);
			JProperty.NativeMethodInfoPtr__ctor_Public_Void_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666429);
			JProperty.NativeMethodInfoPtr__ctor_Internal_Void_JProperty_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666430);
			JProperty.NativeMethodInfoPtr_GetItem_Internal_Virtual_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666431);
			JProperty.NativeMethodInfoPtr_SetItem_Internal_Virtual_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666432);
			JProperty.NativeMethodInfoPtr_RemoveItem_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666433);
			JProperty.NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666434);
			JProperty.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666435);
			JProperty.NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666436);
			JProperty.NativeMethodInfoPtr_ContainsItem_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666437);
			JProperty.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666438);
			JProperty.NativeMethodInfoPtr_ClearItems_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666439);
			JProperty.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666440);
			JProperty.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666441);
			JProperty.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666442);
			JProperty.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666443);
			JProperty.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666444);
			JProperty.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666445);
			JProperty.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666446);
			JProperty.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666447);
			JProperty.NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666448);
			JProperty.NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty>.NativeClassPtr, 100666449);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005FDC4 File Offset: 0x0005DFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758717, XrefRangeEnd = 758735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005FE58 File Offset: 0x0005E058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758735, XrefRangeEnd = 758749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_WriteToAsync_Private_Task_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0005FEF4 File Offset: 0x0005E0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758749, XrefRangeEnd = 758750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, Il2CppReferenceArray<JsonConverter> converters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_WriteValueAsync_Private_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0005FF70 File Offset: 0x0005E170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758750, XrefRangeEnd = 758751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JProperty>>(intPtr3) : null;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0005FFCC File Offset: 0x0005E1CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 758767, RefRangeEnd = 758769, XrefRangeStart = 758751, XrefRangeEnd = 758767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JProperty>>(intPtr3) : null;
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0006003C File Offset: 0x0005E23C
		public unsafe override IList<JToken> ChildrenTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x00060088 File Offset: 0x0005E288
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x000600C0 File Offset: 0x0005E2C0
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x00060100 File Offset: 0x0005E300
		public new unsafe JToken Value
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 758769, RefRangeEnd = 758774, XrefRangeStart = 758769, XrefRangeEnd = 758769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_get_Value_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 758776, RefRangeEnd = 758778, XrefRangeStart = 758774, XrefRangeEnd = 758776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_set_Value_Public_set_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00060144 File Offset: 0x0005E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758778, XrefRangeEnd = 758786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty(JProperty other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr__ctor_Public_Void_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00060190 File Offset: 0x0005E390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758786, XrefRangeEnd = 758794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty(JProperty other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr__ctor_Internal_Void_JProperty_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000601F0 File Offset: 0x0005E3F0
		[CallerCount(0)]
		public unsafe override JToken GetItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_GetItem_Internal_Virtual_JToken_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00060248 File Offset: 0x0005E448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758794, XrefRangeEnd = 758810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetItem(int index, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_SetItem_Internal_Virtual_Void_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000602A4 File Offset: 0x0005E4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758810, XrefRangeEnd = 758824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool RemoveItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_RemoveItem_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000602FC File Offset: 0x0005E4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758824, XrefRangeEnd = 758838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00060348 File Offset: 0x0005E548
		[CallerCount(0)]
		public unsafe override int IndexOfItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000603A0 File Offset: 0x0005E5A0
		[CallerCount(0)]
		public unsafe override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipParentCheck;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyAnnotations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00060424 File Offset: 0x0005E624
		[CallerCount(0)]
		public unsafe override bool ContainsItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_ContainsItem_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0006047C File Offset: 0x0005E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758838, XrefRangeEnd = 758842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MergeItem(Object content, JsonMergeSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000604DC File Offset: 0x0005E6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758842, XrefRangeEnd = 758856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_ClearItems_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00060518 File Offset: 0x0005E718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758856, XrefRangeEnd = 758861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeepEquals(JToken node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00060570 File Offset: 0x0005E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758861, XrefRangeEnd = 758871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JToken CloneToken(JsonCloneSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x000605CC File Offset: 0x0005E7CC
		public unsafe override JTokenType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00060614 File Offset: 0x0005E814
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 758884, RefRangeEnd = 758887, XrefRangeStart = 758871, XrefRangeEnd = 758884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00060660 File Offset: 0x0005E860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758887, XrefRangeEnd = 758888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty(string name, [Optional] Il2CppReferenceArray<Object> content)
		{
			if (content == null)
			{
				content = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000606CC File Offset: 0x0005E8CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 758910, RefRangeEnd = 758913, XrefRangeStart = 758888, XrefRangeEnd = 758910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty(string name, Object content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0006072C File Offset: 0x0005E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758913, XrefRangeEnd = 758914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(JsonWriter writer, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00060798 File Offset: 0x0005E998
		[CallerCount(0)]
		public unsafe override int GetDeepHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JProperty.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000607E0 File Offset: 0x0005E9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758914, XrefRangeEnd = 758915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JProperty Load(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00060824 File Offset: 0x0005EA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758927, RefRangeEnd = 758928, XrefRangeStart = 758915, XrefRangeEnd = 758927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr3) : null;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00007827 File Offset: 0x00005A27
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00007837 File Offset: 0x00005A37
		public Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(task, writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00007849 File Offset: 0x00005A49
		public JProperty(string name, params Object[] content)
			: this(name, new Il2CppReferenceArray<Object>(content))
		{
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00007858 File Offset: 0x00005A58
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			this.WriteTo(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00007867 File Offset: 0x00005A67
		public JProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0006087C File Offset: 0x0005EA7C
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x00007870 File Offset: 0x00005A70
		public unsafe JProperty.JPropertyList _content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.NativeFieldInfoPtr__content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JProperty.JPropertyList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x000608AC File Offset: 0x0005EAAC
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0000788F File Offset: 0x00005A8F
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr__content;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Private_Task_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Private_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_CancellationToken_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JProperty_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_JToken_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_JToken_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JProperty_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JProperty_JsonCloneSettings_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Internal_Virtual_JToken_Int32_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Internal_Virtual_Void_Int32_JToken_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_Void_Int32_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_ContainsItem_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Internal_Virtual_Void_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JProperty_JsonReader_JsonLoadSettings_0;

		// Token: 0x02000205 RID: 517
		public class JPropertyList : Object
		{
			// Token: 0x0600206F RID: 8303 RVA: 0x00092664 File Offset: 0x00090864
			// Note: this type is marked as 'beforefieldinit'.
			static JPropertyList()
			{
				Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JProperty>.NativeClassPtr, "JPropertyList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr);
				JProperty.JPropertyList.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, "_token");
				JProperty.JPropertyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666450);
				JProperty.JPropertyList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666451);
				JProperty.JPropertyList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666452);
				JProperty.JPropertyList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666453);
				JProperty.JPropertyList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666454);
				JProperty.JPropertyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666455);
				JProperty.JPropertyList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666456);
				JProperty.JPropertyList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666457);
				JProperty.JPropertyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666458);
				JProperty.JPropertyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666459);
				JProperty.JPropertyList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666460);
				JProperty.JPropertyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666461);
				JProperty.JPropertyList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666462);
				JProperty.JPropertyList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666463);
				JProperty.JPropertyList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, 100666464);
			}

			// Token: 0x06002070 RID: 8304 RVA: 0x000927D0 File Offset: 0x000909D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758625, XrefRangeEnd = 758630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<JToken> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002071 RID: 8305 RVA: 0x00092810 File Offset: 0x00090A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002072 RID: 8306 RVA: 0x00092850 File Offset: 0x00090A50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Add(JToken item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002073 RID: 8307 RVA: 0x00092894 File Offset: 0x00090A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758630, XrefRangeEnd = 758631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002074 RID: 8308 RVA: 0x000928C8 File Offset: 0x00090AC8
			[CallerCount(0)]
			public unsafe virtual bool Contains(JToken item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002075 RID: 8309 RVA: 0x00092918 File Offset: 0x00090B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758631, XrefRangeEnd = 758633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Il2CppReferenceArray<JToken> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002076 RID: 8310 RVA: 0x00092968 File Offset: 0x00090B68
			[CallerCount(0)]
			public unsafe virtual bool Remove(JToken item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x06002077 RID: 8311 RVA: 0x000929B8 File Offset: 0x00090BB8
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x06002078 RID: 8312 RVA: 0x000929F4 File Offset: 0x00090BF4
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002079 RID: 8313 RVA: 0x00092A30 File Offset: 0x00090C30
			[CallerCount(0)]
			public unsafe virtual int IndexOf(JToken item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600207A RID: 8314 RVA: 0x00092A80 File Offset: 0x00090C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758633, XrefRangeEnd = 758634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Insert(int index, JToken item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207B RID: 8315 RVA: 0x00092AD0 File Offset: 0x00090CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758634, XrefRangeEnd = 758635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700092B RID: 2347
			public unsafe virtual JToken this[int index]
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758635, XrefRangeEnd = 758641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x00092BAC File Offset: 0x00090DAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JPropertyList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207F RID: 8319 RVA: 0x00010408 File Offset: 0x0000E608
			public JPropertyList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x06002080 RID: 8320 RVA: 0x00092BE8 File Offset: 0x00090DE8
			// (set) Token: 0x06002081 RID: 8321 RVA: 0x00010411 File Offset: 0x0000E611
			public unsafe JToken _token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList.NativeFieldInfoPtr__token);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList.NativeFieldInfoPtr__token), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeFieldInfoPtr__token;

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0;

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0;

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0;

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0;

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0;

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0;

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000236 RID: 566
			[ObfuscatedName("Newtonsoft.Json.Linq.JProperty+JPropertyList+<GetEnumerator>d__1")]
			public sealed class _GetEnumerator_d__1 : Object
			{
				// Token: 0x06002304 RID: 8964 RVA: 0x00099BF0 File Offset: 0x00097DF0
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__1()
				{
					Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JProperty.JPropertyList>.NativeClassPtr, "<GetEnumerator>d__1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, "<>1__state");
					JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, "<>2__current");
					JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, "<>4__this");
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666465);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666466);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666467);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666468);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666469);
					JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr, 100666470);
				}

				// Token: 0x06002305 RID: 8965 RVA: 0x00099CD0 File Offset: 0x00097ED0
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__1(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty.JPropertyList._GetEnumerator_d__1>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002306 RID: 8966 RVA: 0x00099D18 File Offset: 0x00097F18
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002307 RID: 8967 RVA: 0x00099D4C File Offset: 0x00097F4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758619, XrefRangeEnd = 758620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000A0F RID: 2575
				// (get) Token: 0x06002308 RID: 8968 RVA: 0x00099D88 File Offset: 0x00097F88
				public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
					}
				}

				// Token: 0x06002309 RID: 8969 RVA: 0x00099DC8 File Offset: 0x00097FC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758620, XrefRangeEnd = 758625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000A10 RID: 2576
				// (get) Token: 0x0600230A RID: 8970 RVA: 0x00099DFC File Offset: 0x00097FFC
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty.JPropertyList._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600230B RID: 8971 RVA: 0x00011E65 File Offset: 0x00010065
				public _GetEnumerator_d__1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000A0C RID: 2572
				// (get) Token: 0x0600230C RID: 8972 RVA: 0x00099E3C File Offset: 0x0009803C
				// (set) Token: 0x0600230D RID: 8973 RVA: 0x00011E6E File Offset: 0x0001006E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000A0D RID: 2573
				// (get) Token: 0x0600230E RID: 8974 RVA: 0x00099E64 File Offset: 0x00098064
				// (set) Token: 0x0600230F RID: 8975 RVA: 0x00011E89 File Offset: 0x00010089
				public unsafe JToken __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A0E RID: 2574
				// (get) Token: 0x06002310 RID: 8976 RVA: 0x00099E94 File Offset: 0x00098094
				// (set) Token: 0x06002311 RID: 8977 RVA: 0x00011EA8 File Offset: 0x000100A8
				public unsafe JProperty.JPropertyList __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JProperty.JPropertyList>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty.JPropertyList._GetEnumerator_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018E1 RID: 6369
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040018E2 RID: 6370
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040018E3 RID: 6371
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040018E4 RID: 6372
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040018E5 RID: 6373
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040018E6 RID: 6374
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040018E7 RID: 6375
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

				// Token: 0x040018E8 RID: 6376
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040018E9 RID: 6377
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000206 RID: 518
		[ObfuscatedName("Newtonsoft.Json.Linq.JProperty+<LoadAsync>d__4")]
		public sealed class _LoadAsync_d__4 : ValueType
		{
			// Token: 0x06002082 RID: 8322 RVA: 0x00092C18 File Offset: 0x00090E18
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__4()
			{
				Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JProperty>.NativeClassPtr, "<LoadAsync>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr);
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "<>1__state");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "<>t__builder");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "reader");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "cancellationToken");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "settings");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr__p_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "<p>5__2");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "<>u__1");
				JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, "<>u__2");
				JProperty._LoadAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, 100666471);
				JProperty._LoadAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr, 100666472);
			}

			// Token: 0x06002083 RID: 8323 RVA: 0x00092D0C File Offset: 0x00090F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758641, XrefRangeEnd = 758690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty._LoadAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002084 RID: 8324 RVA: 0x00092D44 File Offset: 0x00090F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758690, XrefRangeEnd = 758696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty._LoadAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002085 RID: 8325 RVA: 0x00010430 File Offset: 0x0000E630
			public _LoadAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002086 RID: 8326 RVA: 0x00010439 File Offset: 0x0000E639
			public _LoadAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty._LoadAsync_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06002087 RID: 8327 RVA: 0x00092D8C File Offset: 0x00090F8C
			// (set) Token: 0x06002088 RID: 8328 RVA: 0x0001044B File Offset: 0x0000E64B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06002089 RID: 8329 RVA: 0x00092DB4 File Offset: 0x00090FB4
			// (set) Token: 0x0600208A RID: 8330 RVA: 0x00010466 File Offset: 0x0000E666
			public AsyncTaskMethodBuilder<JProperty> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JProperty>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JProperty>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JProperty>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x0600208B RID: 8331 RVA: 0x00092DE4 File Offset: 0x00090FE4
			// (set) Token: 0x0600208C RID: 8332 RVA: 0x00010494 File Offset: 0x0000E694
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x0600208D RID: 8333 RVA: 0x00092E14 File Offset: 0x00091014
			// (set) Token: 0x0600208E RID: 8334 RVA: 0x000104B3 File Offset: 0x0000E6B3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x0600208F RID: 8335 RVA: 0x00092E44 File Offset: 0x00091044
			// (set) Token: 0x06002090 RID: 8336 RVA: 0x000104E1 File Offset: 0x0000E6E1
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x06002091 RID: 8337 RVA: 0x00092E74 File Offset: 0x00091074
			// (set) Token: 0x06002092 RID: 8338 RVA: 0x00010500 File Offset: 0x0000E700
			public unsafe JProperty _p_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr__p_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr__p_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x06002093 RID: 8339 RVA: 0x00092EA4 File Offset: 0x000910A4
			// (set) Token: 0x06002094 RID: 8340 RVA: 0x0001051F File Offset: 0x0000E71F
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x06002095 RID: 8341 RVA: 0x00092ED4 File Offset: 0x000910D4
			// (set) Token: 0x06002096 RID: 8342 RVA: 0x0001054D File Offset: 0x0000E74D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._LoadAsync_d__4.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400176A RID: 5994
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400176B RID: 5995
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x0400176C RID: 5996
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400176D RID: 5997
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeFieldInfoPtr__p_5__2;

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001771 RID: 6001
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001772 RID: 6002
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000207 RID: 519
		[ObfuscatedName("Newtonsoft.Json.Linq.JProperty+<WriteToAsync>d__1")]
		public sealed class _WriteToAsync_d__1 : ValueType
		{
			// Token: 0x06002097 RID: 8343 RVA: 0x00092F04 File Offset: 0x00091104
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteToAsync_d__1()
			{
				Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JProperty>.NativeClassPtr, "<WriteToAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr);
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "<>1__state");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "<>t__builder");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "task");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "<>4__this");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "writer");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "cancellationToken");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "converters");
				JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, "<>u__1");
				JProperty._WriteToAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, 100666473);
				JProperty._WriteToAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr, 100666474);
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x00092FF8 File Offset: 0x000911F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758696, XrefRangeEnd = 758710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty._WriteToAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002099 RID: 8345 RVA: 0x00093030 File Offset: 0x00091230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758710, XrefRangeEnd = 758717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JProperty._WriteToAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x0001057B File Offset: 0x0000E77B
			public _WriteToAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x00010584 File Offset: 0x0000E784
			public _WriteToAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JProperty._WriteToAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x0600209C RID: 8348 RVA: 0x00093078 File Offset: 0x00091278
			// (set) Token: 0x0600209D RID: 8349 RVA: 0x00010596 File Offset: 0x0000E796
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x0600209E RID: 8350 RVA: 0x000930A0 File Offset: 0x000912A0
			// (set) Token: 0x0600209F RID: 8351 RVA: 0x000105B1 File Offset: 0x0000E7B1
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000930D0 File Offset: 0x000912D0
			// (set) Token: 0x060020A1 RID: 8353 RVA: 0x000105DF File Offset: 0x0000E7DF
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00093100 File Offset: 0x00091300
			// (set) Token: 0x060020A3 RID: 8355 RVA: 0x000105FE File Offset: 0x0000E7FE
			public unsafe JProperty __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00093130 File Offset: 0x00091330
			// (set) Token: 0x060020A5 RID: 8357 RVA: 0x0001061D File Offset: 0x0000E81D
			public unsafe JsonWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00093160 File Offset: 0x00091360
			// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0001063C File Offset: 0x0000E83C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00093190 File Offset: 0x00091390
			// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0001066A File Offset: 0x0000E86A
			public unsafe Il2CppReferenceArray<JsonConverter> converters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_converters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JsonConverter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr_converters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x060020AA RID: 8362 RVA: 0x000931C0 File Offset: 0x000913C0
			// (set) Token: 0x060020AB RID: 8363 RVA: 0x00010689 File Offset: 0x0000E889
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JProperty._WriteToAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001773 RID: 6003
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001774 RID: 6004
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001779 RID: 6009
			private static readonly IntPtr NativeFieldInfoPtr_converters;

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
