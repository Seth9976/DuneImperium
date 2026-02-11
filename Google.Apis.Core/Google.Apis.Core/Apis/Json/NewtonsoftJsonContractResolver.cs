using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Google.Apis.Json
{
	// Token: 0x02000023 RID: 35
	public class NewtonsoftJsonContractResolver : DefaultContractResolver
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000937C File Offset: 0x0000757C
		// Note: this type is marked as 'beforefieldinit'.
		static NewtonsoftJsonContractResolver()
		{
			Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Json", "NewtonsoftJsonContractResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr);
			NewtonsoftJsonContractResolver.NativeFieldInfoPtr_DateTimeConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr, "DateTimeConverter");
			NewtonsoftJsonContractResolver.NativeFieldInfoPtr_ExplicitNullConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr, "ExplicitNullConverter");
			NewtonsoftJsonContractResolver.NativeMethodInfoPtr_CreateContract_Protected_Virtual_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr, 100663508);
			NewtonsoftJsonContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr, 100663509);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000093FC File Offset: 0x000075FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211177, XrefRangeEnd = 1211192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JsonContract CreateContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewtonsoftJsonContractResolver.NativeMethodInfoPtr_CreateContract_Protected_Virtual_JsonContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00009458 File Offset: 0x00007658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211192, XrefRangeEnd = 1211196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewtonsoftJsonContractResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewtonsoftJsonContractResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002824 File Offset: 0x00000A24
		public NewtonsoftJsonContractResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00009494 File Offset: 0x00007694
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000282D File Offset: 0x00000A2D
		public unsafe static JsonConverter DateTimeConverter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NewtonsoftJsonContractResolver.NativeFieldInfoPtr_DateTimeConverter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewtonsoftJsonContractResolver.NativeFieldInfoPtr_DateTimeConverter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000094BC File Offset: 0x000076BC
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000283F File Offset: 0x00000A3F
		public unsafe static JsonConverter ExplicitNullConverter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NewtonsoftJsonContractResolver.NativeFieldInfoPtr_ExplicitNullConverter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewtonsoftJsonContractResolver.NativeFieldInfoPtr_ExplicitNullConverter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeConverter;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_ExplicitNullConverter;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Protected_Virtual_JsonContract_Type_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
