using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000181 RID: 385
	public class ICustomStyle : Il2CppObjectBase
	{
		// Token: 0x06001CFF RID: 7423 RVA: 0x0008456C File Offset: 0x0008276C
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomStyle()
		{
			Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ICustomStyle");
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667561);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667562);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Color_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667563);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Texture2D_byref_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667564);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Sprite_byref_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667565);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_VectorImage_byref_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667566);
			ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomStyle>.NativeClassPtr, 100667567);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00084620 File Offset: 0x00082820
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<float> property, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0008468C File Offset: 0x0008288C
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<int> property, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000846F8 File Offset: 0x000828F8
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<Color> property, out Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Color_byref_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00084764 File Offset: 0x00082964
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Texture2D_byref_Texture2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Texture2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000847E4 File Offset: 0x000829E4
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Sprite_byref_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Sprite(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00084864 File Offset: 0x00082A64
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_VectorImage_byref_VectorImage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new VectorImage(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000848E4 File Offset: 0x00082AE4
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(CustomStyleProperty<string> property, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(property));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomStyle.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0000CDE7 File Offset: 0x0000AFE7
		public ICustomStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Single_byref_Single_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Int32_byref_Int32_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Color_byref_Color_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Texture2D_byref_Texture2D_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_Sprite_byref_Sprite_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_VectorImage_byref_VectorImage_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_CustomStyleProperty_1_String_byref_String_0;
	}
}
