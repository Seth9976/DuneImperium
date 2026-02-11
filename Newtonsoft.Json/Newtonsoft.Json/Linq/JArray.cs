using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B6 RID: 182
	public class JArray : JContainer
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x000599DC File Offset: 0x00057BDC
		// Note: this type is marked as 'beforefieldinit'.
		static JArray()
		{
			Il2CppClassPointerStore<JArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JArray>.NativeClassPtr);
			JArray.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray>.NativeClassPtr, "_values");
			JArray.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666138);
			JArray.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666139);
			JArray.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666140);
			JArray.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666141);
			JArray.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666142);
			JArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666143);
			JArray.NativeMethodInfoPtr__ctor_Public_Void_JArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666144);
			JArray.NativeMethodInfoPtr__ctor_Internal_Void_JArray_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666145);
			JArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666146);
			JArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666147);
			JArray.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666148);
			JArray.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666149);
			JArray.NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666150);
			JArray.NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666151);
			JArray.NativeMethodInfoPtr_Parse_Public_Static_JArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666152);
			JArray.NativeMethodInfoPtr_Parse_Public_Static_JArray_String_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666153);
			JArray.NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666154);
			JArray.NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666155);
			JArray.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666156);
			JArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666157);
			JArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666158);
			JArray.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666159);
			JArray.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666160);
			JArray.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666161);
			JArray.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666162);
			JArray.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666163);
			JArray.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666164);
			JArray.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666165);
			JArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666166);
			JArray.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666167);
			JArray.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666168);
			JArray.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666169);
			JArray.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666170);
			JArray.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666171);
			JArray.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666172);
			JArray.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray>.NativeClassPtr, 100666173);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00059CF0 File Offset: 0x00057EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756463, XrefRangeEnd = 756476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00059D84 File Offset: 0x00057F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756476, XrefRangeEnd = 756492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JArray>>(intPtr3) : null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00059DE0 File Offset: 0x00057FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756508, RefRangeEnd = 756509, XrefRangeStart = 756492, XrefRangeEnd = 756508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JArray>>(intPtr3) : null;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00059E50 File Offset: 0x00058050
		public unsafe override IList<JToken> ChildrenTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00059E9C File Offset: 0x0005809C
		public unsafe override JTokenType Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00059EE4 File Offset: 0x000580E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 756517, RefRangeEnd = 756523, XrefRangeStart = 756509, XrefRangeEnd = 756517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00059F20 File Offset: 0x00058120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756523, XrefRangeEnd = 756531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JArray(JArray other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr__ctor_Public_Void_JArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00059F6C File Offset: 0x0005816C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756531, XrefRangeEnd = 756539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JArray(JArray other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr__ctor_Internal_Void_JArray_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00059FCC File Offset: 0x000581CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756547, RefRangeEnd = 756548, XrefRangeStart = 756539, XrefRangeEnd = 756547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JArray([Optional] Il2CppReferenceArray<Object> content)
		{
			if (content == null)
			{
				content = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0005A024 File Offset: 0x00058224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756547, RefRangeEnd = 756548, XrefRangeStart = 756547, XrefRangeEnd = 756548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JArray(Object content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0005A070 File Offset: 0x00058270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756548, XrefRangeEnd = 756552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeepEquals(JToken node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0005A0C8 File Offset: 0x000582C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756552, XrefRangeEnd = 756563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JToken CloneToken(JsonCloneSettings settings = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0005A124 File Offset: 0x00058324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756563, XrefRangeEnd = 756564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray Load(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0005A168 File Offset: 0x00058368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 756574, RefRangeEnd = 756576, XrefRangeStart = 756564, XrefRangeEnd = 756574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0005A1C0 File Offset: 0x000583C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756576, XrefRangeEnd = 756577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray Parse(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Parse_Public_Static_JArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0005A204 File Offset: 0x00058404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756592, RefRangeEnd = 756593, XrefRangeStart = 756577, XrefRangeEnd = 756592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray Parse(string json, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Parse_Public_Static_JArray_String_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0005A25C File Offset: 0x0005845C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756593, XrefRangeEnd = 756600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray FromObject(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0005A2A0 File Offset: 0x000584A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756600, XrefRangeEnd = 756606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JArray FromObject(Object o, JsonSerializer jsonSerializer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr3) : null;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0005A2F8 File Offset: 0x000584F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756606, XrefRangeEnd = 756612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000463 RID: 1123
		public unsafe override JToken this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756612, XrefRangeEnd = 756630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756630, XrefRangeEnd = 756648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000464 RID: 1124
		public unsafe virtual JToken this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 756648, RefRangeEnd = 756651, XrefRangeStart = 756648, XrefRangeEnd = 756648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 756651, RefRangeEnd = 756652, XrefRangeStart = 756651, XrefRangeEnd = 756651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0005A4BC File Offset: 0x000586BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756652, XrefRangeEnd = 756655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOfItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0005A514 File Offset: 0x00058714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756655, XrefRangeEnd = 756662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0005A574 File Offset: 0x00058774
		[CallerCount(0)]
		public unsafe virtual int IndexOf(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0005A5C4 File Offset: 0x000587C4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0005A614 File Offset: 0x00058814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756662, RefRangeEnd = 756663, XrefRangeStart = 756662, XrefRangeEnd = 756662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0005A654 File Offset: 0x00058854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756663, XrefRangeEnd = 756669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<JToken> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0005A694 File Offset: 0x00058894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 756669, RefRangeEnd = 756671, XrefRangeStart = 756669, XrefRangeEnd = 756669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0005A6D8 File Offset: 0x000588D8
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0005A70C File Offset: 0x0005890C
		[CallerCount(0)]
		public unsafe virtual bool Contains(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0005A75C File Offset: 0x0005895C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0005A7AC File Offset: 0x000589AC
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0005A7E8 File Offset: 0x000589E8
		[CallerCount(0)]
		public unsafe virtual bool Remove(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0005A838 File Offset: 0x00058A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756671, XrefRangeEnd = 756672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDeepHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JArray.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000075D9 File Offset: 0x000057D9
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000075E9 File Offset: 0x000057E9
		public JArray(params Object[] content)
			: this(new Il2CppReferenceArray<Object>(content))
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000075F7 File Offset: 0x000057F7
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			this.WriteTo(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00007606 File Offset: 0x00005806
		public JArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0005A880 File Offset: 0x00058A80
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x0000760F File Offset: 0x0000580F
		public unsafe List<JToken> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_CancellationToken_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JArray_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JArray_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JArray_JsonCloneSettings_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JArray_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JArray_String_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JArray_String_JsonLoadSettings_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JArray_Object_JsonSerializer_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_Int32_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_JToken_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_JToken_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_JToken_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_JToken_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_JToken_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_JToken_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_JToken_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0;

		// Token: 0x020001F8 RID: 504
		[ObfuscatedName("Newtonsoft.Json.Linq.JArray+<LoadAsync>d__2")]
		public sealed class _LoadAsync_d__2 : ValueType
		{
			// Token: 0x06001F81 RID: 8065 RVA: 0x00090164 File Offset: 0x0008E364
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__2()
			{
				Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JArray>.NativeClassPtr, "<LoadAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr);
				JArray._LoadAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "<>1__state");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "<>t__builder");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "reader");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "cancellationToken");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "settings");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr__a_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "<a>5__2");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "<>u__1");
				JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, "<>u__2");
				JArray._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, 100666174);
				JArray._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr, 100666175);
			}

			// Token: 0x06001F82 RID: 8066 RVA: 0x00090258 File Offset: 0x0008E458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756373, XrefRangeEnd = 756420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F83 RID: 8067 RVA: 0x00090290 File Offset: 0x0008E490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756420, XrefRangeEnd = 756426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F84 RID: 8068 RVA: 0x0000F79B File Offset: 0x0000D99B
			public _LoadAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F85 RID: 8069 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
			public _LoadAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray._LoadAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000902D8 File Offset: 0x0008E4D8
			// (set) Token: 0x06001F87 RID: 8071 RVA: 0x0000F7B6 File Offset: 0x0000D9B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00090300 File Offset: 0x0008E500
			// (set) Token: 0x06001F89 RID: 8073 RVA: 0x0000F7D1 File Offset: 0x0000D9D1
			public AsyncTaskMethodBuilder<JArray> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JArray>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JArray>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JArray>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00090330 File Offset: 0x0008E530
			// (set) Token: 0x06001F8B RID: 8075 RVA: 0x0000F7FF File Offset: 0x0000D9FF
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00090360 File Offset: 0x0008E560
			// (set) Token: 0x06001F8D RID: 8077 RVA: 0x0000F81E File Offset: 0x0000DA1E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00090390 File Offset: 0x0008E590
			// (set) Token: 0x06001F8F RID: 8079 RVA: 0x0000F84C File Offset: 0x0000DA4C
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06001F90 RID: 8080 RVA: 0x000903C0 File Offset: 0x0008E5C0
			// (set) Token: 0x06001F91 RID: 8081 RVA: 0x0000F86B File Offset: 0x0000DA6B
			public unsafe JArray _a_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr__a_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr__a_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06001F92 RID: 8082 RVA: 0x000903F0 File Offset: 0x0008E5F0
			// (set) Token: 0x06001F93 RID: 8083 RVA: 0x0000F88A File Offset: 0x0000DA8A
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00090420 File Offset: 0x0008E620
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._LoadAsync_d__2.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeFieldInfoPtr__a_5__2;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001F9 RID: 505
		[ObfuscatedName("Newtonsoft.Json.Linq.JArray+<WriteToAsync>d__0")]
		public sealed class _WriteToAsync_d__0 : ValueType
		{
			// Token: 0x06001F96 RID: 8086 RVA: 0x00090450 File Offset: 0x0008E650
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteToAsync_d__0()
			{
				Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JArray>.NativeClassPtr, "<WriteToAsync>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr);
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "<>1__state");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "<>t__builder");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "writer");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "cancellationToken");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "<>4__this");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "converters");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "<>u__1");
				JArray._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, "<i>5__2");
				JArray._WriteToAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, 100666176);
				JArray._WriteToAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr, 100666177);
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x00090544 File Offset: 0x0008E744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756426, XrefRangeEnd = 756459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray._WriteToAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x0009057C File Offset: 0x0008E77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756459, XrefRangeEnd = 756463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JArray._WriteToAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x0000F8E6 File Offset: 0x0000DAE6
			public _WriteToAsync_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x0000F8EF File Offset: 0x0000DAEF
			public _WriteToAsync_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JArray._WriteToAsync_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000905C4 File Offset: 0x0008E7C4
			// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0000F901 File Offset: 0x0000DB01
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000905EC File Offset: 0x0008E7EC
			// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000F91C File Offset: 0x0000DB1C
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0009061C File Offset: 0x0008E81C
			// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000F94A File Offset: 0x0000DB4A
			public unsafe JsonWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0009064C File Offset: 0x0008E84C
			// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0000F969 File Offset: 0x0000DB69
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0009067C File Offset: 0x0008E87C
			// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0000F997 File Offset: 0x0000DB97
			public unsafe JArray __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000906AC File Offset: 0x0008E8AC
			// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0000F9B6 File Offset: 0x0000DBB6
			public unsafe Il2CppReferenceArray<JsonConverter> converters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_converters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JsonConverter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr_converters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000906DC File Offset: 0x0008E8DC
			// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0000F9D5 File Offset: 0x0000DBD5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0009070C File Offset: 0x0008E90C
			// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0000FA03 File Offset: 0x0000DC03
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JArray._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040016E8 RID: 5864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016E9 RID: 5865
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016EA RID: 5866
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x040016EB RID: 5867
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040016EC RID: 5868
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeFieldInfoPtr_converters;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
