using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AB RID: 171
	public class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode>
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x00058824 File Offset: 0x00056A24
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaNodeCollection()
		{
			Il2CppClassPointerStore<JsonSchemaNodeCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaNodeCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaNodeCollection>.NativeClassPtr);
			JsonSchemaNodeCollection.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNodeCollection>.NativeClassPtr, 100666054);
			JsonSchemaNodeCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNodeCollection>.NativeClassPtr, 100666055);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0005887C File Offset: 0x00056A7C
		[CallerCount(0)]
		public unsafe override string GetKeyForItem(JsonSchemaNode item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSchemaNodeCollection.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonSchemaNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000588D0 File Offset: 0x00056AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755612, XrefRangeEnd = 755615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaNodeCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaNodeCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNodeCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000074F7 File Offset: 0x000056F7
		public JsonSchemaNodeCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonSchemaNode_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
