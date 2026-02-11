using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000073 RID: 115
	public class BootConfigData : Object
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00021720 File Offset: 0x0001F920
		// Note: this type is marked as 'beforefieldinit'.
		static BootConfigData()
		{
			Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BootConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
			BootConfigData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, "m_Ptr");
			BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663692);
			BootConfigData.AppendDelegateField = IL2CPP.ResolveICall<BootConfigData.AppendDelegate>("UnityEngine.BootConfigData::Append");
			BootConfigData.SetDelegateField = IL2CPP.ResolveICall<BootConfigData.SetDelegate>("UnityEngine.BootConfigData::Set");
			BootConfigData.GetValueDelegateField = IL2CPP.ResolveICall<BootConfigData.GetValueDelegate>("UnityEngine.BootConfigData::GetValue");
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000217A8 File Offset: 0x0001F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645157, XrefRangeEnd = 645162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BootConfigData>(intPtr3) : null;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003F11 File Offset: 0x00002111
		public BootConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000217E8 File Offset: 0x0001F9E8
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003F1A File Offset: 0x0000211A
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003F35 File Offset: 0x00002135
		public void AddKey(string key)
		{
			this.Append(key, null);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00021810 File Offset: 0x0001FA10
		public string Get(string key)
		{
			return this.GetValue(key, 0);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0002182C File Offset: 0x0001FA2C
		public string Get(string key, int index)
		{
			return this.GetValue(key, index);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003F41 File Offset: 0x00002141
		public void Append(string key, string value)
		{
			BootConfigData.AppendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003F5F File Offset: 0x0000215F
		public void Set(string key, string value)
		{
			BootConfigData.SetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00021848 File Offset: 0x0001FA48
		public string GetValue(string key, int index)
		{
			IntPtr intPtr = BootConfigData.GetValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;

		// Token: 0x0400038A RID: 906
		private static readonly BootConfigData.AppendDelegate AppendDelegateField;

		// Token: 0x0400038B RID: 907
		private static readonly BootConfigData.SetDelegate SetDelegateField;

		// Token: 0x0400038C RID: 908
		private static readonly BootConfigData.GetValueDelegate GetValueDelegateField;

		// Token: 0x0200042D RID: 1069
		// (Invoke) Token: 0x06003155 RID: 12629
		private delegate void AppendDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x06003157 RID: 12631
		private delegate void SetDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x0200042F RID: 1071
		// (Invoke) Token: 0x06003159 RID: 12633
		private delegate IntPtr GetValueDelegate(IntPtr @this, IntPtr key, int index);
	}
}
