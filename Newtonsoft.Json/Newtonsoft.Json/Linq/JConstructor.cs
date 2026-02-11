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
	// Token: 0x020000B7 RID: 183
	public class JConstructor : JContainer
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x0005A8B0 File Offset: 0x00058AB0
		// Note: this type is marked as 'beforefieldinit'.
		static JConstructor()
		{
			Il2CppClassPointerStore<JConstructor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JConstructor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JConstructor>.NativeClassPtr);
			JConstructor.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, "_name");
			JConstructor.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, "_values");
			JConstructor.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666178);
			JConstructor.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666179);
			JConstructor.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666180);
			JConstructor.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666181);
			JConstructor.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666182);
			JConstructor.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666183);
			JConstructor.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666184);
			JConstructor.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666185);
			JConstructor.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666186);
			JConstructor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666187);
			JConstructor.NativeMethodInfoPtr__ctor_Public_Void_JConstructor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666188);
			JConstructor.NativeMethodInfoPtr__ctor_Internal_Void_JConstructor_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666189);
			JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666190);
			JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666191);
			JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666192);
			JConstructor.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666193);
			JConstructor.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666194);
			JConstructor.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666195);
			JConstructor.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666196);
			JConstructor.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666197);
			JConstructor.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666198);
			JConstructor.NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666199);
			JConstructor.NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, 100666200);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0005AAD4 File Offset: 0x00058CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756766, XrefRangeEnd = 756779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0005AB68 File Offset: 0x00058D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756779, XrefRangeEnd = 756780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JConstructor>>(intPtr3) : null;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0005ABC4 File Offset: 0x00058DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 756796, RefRangeEnd = 756798, XrefRangeStart = 756780, XrefRangeEnd = 756796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JConstructor>>(intPtr3) : null;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0005AC34 File Offset: 0x00058E34
		public unsafe override IList<JToken> ChildrenTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0005AC80 File Offset: 0x00058E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756798, XrefRangeEnd = 756801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOfItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756801, XrefRangeEnd = 756806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0005AD38 File Offset: 0x00058F38
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x0005AD70 File Offset: 0x00058F70
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0005ADB4 File Offset: 0x00058FB4
		public unsafe override JTokenType Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0005ADFC File Offset: 0x00058FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756806, XrefRangeEnd = 756817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0005AE38 File Offset: 0x00059038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756817, XrefRangeEnd = 756827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor(JConstructor other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Public_Void_JConstructor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0005AE84 File Offset: 0x00059084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756827, XrefRangeEnd = 756837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor(JConstructor other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Internal_Void_JConstructor_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0005AEE4 File Offset: 0x000590E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756837, XrefRangeEnd = 756838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor(string name, [Optional] Il2CppReferenceArray<Object> content)
		{
			if (content == null)
			{
				content = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0005AF50 File Offset: 0x00059150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor(string name, Object content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0005AFB0 File Offset: 0x000591B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 756863, RefRangeEnd = 756870, XrefRangeStart = 756838, XrefRangeEnd = 756863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JConstructor(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0005AFFC File Offset: 0x000591FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756870, XrefRangeEnd = 756875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeepEquals(JToken node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0005B054 File Offset: 0x00059254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756875, XrefRangeEnd = 756887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JToken CloneToken(JsonCloneSettings settings = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0005B0B0 File Offset: 0x000592B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756887, XrefRangeEnd = 756892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700046B RID: 1131
		public unsafe override JToken this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756892, XrefRangeEnd = 756910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756910, XrefRangeEnd = 756928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0005B1D8 File Offset: 0x000593D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756928, XrefRangeEnd = 756930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDeepHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JConstructor.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0005B220 File Offset: 0x00059420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756930, XrefRangeEnd = 756931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JConstructor Load(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JConstructor>(intPtr3) : null;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0005B264 File Offset: 0x00059464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756943, RefRangeEnd = 756944, XrefRangeStart = 756931, XrefRangeEnd = 756943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor.NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JConstructor>(intPtr3) : null;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0000762E File Offset: 0x0000582E
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0000763E File Offset: 0x0000583E
		public JConstructor(string name, params Object[] content)
			: this(name, new Il2CppReferenceArray<Object>(content))
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0000764D File Offset: 0x0000584D
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			this.WriteTo(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0000765C File Offset: 0x0000585C
		public JConstructor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0005B2BC File Offset: 0x000594BC
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x00007665 File Offset: 0x00005865
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0005B2E4 File Offset: 0x000594E4
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00007684 File Offset: 0x00005884
		public unsafe List<JToken> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_CancellationToken_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JConstructor_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JConstructor_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JConstructor_JsonCloneSettings_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JConstructor_JsonReader_JsonLoadSettings_0;

		// Token: 0x020001FA RID: 506
		[ObfuscatedName("Newtonsoft.Json.Linq.JConstructor+<LoadAsync>d__2")]
		public sealed class _LoadAsync_d__2 : ValueType
		{
			// Token: 0x06001FAB RID: 8107 RVA: 0x00090734 File Offset: 0x0008E934
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__2()
			{
				Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, "<LoadAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr);
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "<>1__state");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "<>t__builder");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "reader");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "cancellationToken");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "settings");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr__c_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "<c>5__2");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "<>u__1");
				JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, "<>u__2");
				JConstructor._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, 100666201);
				JConstructor._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr, 100666202);
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x00090828 File Offset: 0x0008EA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756672, XrefRangeEnd = 756721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x00090860 File Offset: 0x0008EA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756721, XrefRangeEnd = 756727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FAE RID: 8110 RVA: 0x0000FA1E File Offset: 0x0000DC1E
			public _LoadAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0000FA27 File Offset: 0x0000DC27
			public _LoadAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor._LoadAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000908A8 File Offset: 0x0008EAA8
			// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x0000FA39 File Offset: 0x0000DC39
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000908D0 File Offset: 0x0008EAD0
			// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x0000FA54 File Offset: 0x0000DC54
			public AsyncTaskMethodBuilder<JConstructor> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JConstructor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JConstructor>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JConstructor>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00090900 File Offset: 0x0008EB00
			// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0000FA82 File Offset: 0x0000DC82
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00090930 File Offset: 0x0008EB30
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0000FAA1 File Offset: 0x0000DCA1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00090960 File Offset: 0x0008EB60
			// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0000FACF File Offset: 0x0000DCCF
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00090990 File Offset: 0x0008EB90
			// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0000FAEE File Offset: 0x0000DCEE
			public unsafe JConstructor _c_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr__c_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JConstructor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr__c_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000909C0 File Offset: 0x0008EBC0
			// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0000FB0D File Offset: 0x0000DD0D
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06001FBE RID: 8126 RVA: 0x000909F0 File Offset: 0x0008EBF0
			// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0000FB3B File Offset: 0x0000DD3B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._LoadAsync_d__2.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr__c_5__2;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FB RID: 507
		[ObfuscatedName("Newtonsoft.Json.Linq.JConstructor+<WriteToAsync>d__0")]
		public sealed class _WriteToAsync_d__0 : ValueType
		{
			// Token: 0x06001FC0 RID: 8128 RVA: 0x00090A20 File Offset: 0x0008EC20
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteToAsync_d__0()
			{
				Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JConstructor>.NativeClassPtr, "<WriteToAsync>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr);
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "<>1__state");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "<>t__builder");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "writer");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "<>4__this");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "cancellationToken");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "converters");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "<>u__1");
				JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, "<i>5__2");
				JConstructor._WriteToAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, 100666203);
				JConstructor._WriteToAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr, 100666204);
			}

			// Token: 0x06001FC1 RID: 8129 RVA: 0x00090B14 File Offset: 0x0008ED14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756727, XrefRangeEnd = 756762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor._WriteToAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC2 RID: 8130 RVA: 0x00090B4C File Offset: 0x0008ED4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756762, XrefRangeEnd = 756766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JConstructor._WriteToAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC3 RID: 8131 RVA: 0x0000FB69 File Offset: 0x0000DD69
			public _WriteToAsync_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FC4 RID: 8132 RVA: 0x0000FB72 File Offset: 0x0000DD72
			public _WriteToAsync_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JConstructor._WriteToAsync_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00090B94 File Offset: 0x0008ED94
			// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0000FB84 File Offset: 0x0000DD84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00090BBC File Offset: 0x0008EDBC
			// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0000FB9F File Offset: 0x0000DD9F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00090BEC File Offset: 0x0008EDEC
			// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0000FBCD File Offset: 0x0000DDCD
			public unsafe JsonWriter writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00090C1C File Offset: 0x0008EE1C
			// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000FBEC File Offset: 0x0000DDEC
			public unsafe JConstructor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JConstructor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00090C4C File Offset: 0x0008EE4C
			// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000FC0B File Offset: 0x0000DE0B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00090C7C File Offset: 0x0008EE7C
			// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0000FC39 File Offset: 0x0000DE39
			public unsafe Il2CppReferenceArray<JsonConverter> converters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_converters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JsonConverter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr_converters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00090CAC File Offset: 0x0008EEAC
			// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000FC58 File Offset: 0x0000DE58
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00090CDC File Offset: 0x0008EEDC
			// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0000FC86 File Offset: 0x0000DE86
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JConstructor._WriteToAsync_d__0.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeFieldInfoPtr_writer;

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeFieldInfoPtr_converters;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
