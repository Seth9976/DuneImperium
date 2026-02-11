using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Activation;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F4 RID: 756
	public class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06002EDA RID: 11994 RVA: 0x000F1740 File Offset: 0x000EF940
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCallDictionary()
		{
			Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCallDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr);
			ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, "InternalKeys");
			ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100670740);
			ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100670741);
			ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100670742);
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000F17C0 File Offset: 0x000EF9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383128, XrefRangeEnd = 1383135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCallDictionary(IConstructionCallMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000F180C File Offset: 0x000EFA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383135, XrefRangeEnd = 1383193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetMethodProperty(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000F1868 File Offset: 0x000EFA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383193, XrefRangeEnd = 1383272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMethodProperty(string key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x0000FF25 File Offset: 0x0000E125
		public ConstructionCallDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000F18C8 File Offset: 0x000EFAC8
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x0000FF2E File Offset: 0x0000E12E
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026FC RID: 9980
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x040026FD RID: 9981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0;

		// Token: 0x040026FE RID: 9982
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0;

		// Token: 0x040026FF RID: 9983
		private static readonly IntPtr NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0;
	}
}
