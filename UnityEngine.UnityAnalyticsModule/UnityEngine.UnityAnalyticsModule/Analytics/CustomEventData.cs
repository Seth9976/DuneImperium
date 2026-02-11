using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x02000008 RID: 8
	public class CustomEventData
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00003DCC File Offset: 0x00001FCC
		public ~CustomEventData()
		{
			this.Destroy();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000259E File Offset: 0x0000079E
		public void Destroy()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000025AB File Offset: 0x000007AB
		public void Dispose()
		{
			this.Destroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000025BC File Offset: 0x000007BC
		public static IntPtr Internal_Create(CustomEventData ced, string name)
		{
			return CustomEventData.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ced), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025D4 File Offset: 0x000007D4
		public static void Internal_Destroy(IntPtr ptr)
		{
			CustomEventData.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000025E1 File Offset: 0x000007E1
		public bool AddString(string key, string value)
		{
			return CustomEventData.AddStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000025FF File Offset: 0x000007FF
		public bool AddInt32(string key, int value)
		{
			return CustomEventData.AddInt32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002618 File Offset: 0x00000818
		public bool AddUInt32(string key, uint value)
		{
			return CustomEventData.AddUInt32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002631 File Offset: 0x00000831
		public bool AddInt64(string key, long value)
		{
			return CustomEventData.AddInt64DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000264A File Offset: 0x0000084A
		public bool AddUInt64(string key, ulong value)
		{
			return CustomEventData.AddUInt64DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002663 File Offset: 0x00000863
		public bool AddBool(string key, bool value)
		{
			return CustomEventData.AddBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000267C File Offset: 0x0000087C
		public bool AddDouble(string key, double value)
		{
			return CustomEventData.AddDoubleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), value);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003DFC File Offset: 0x00001FFC
		public bool AddDictionary(IDictionary<string, Object> eventData)
		{
			foreach (KeyValuePair<string, Object> keyValuePair in eventData)
			{
				string key = keyValuePair.Key;
				Object value = keyValuePair.Value;
				bool flag = value == null;
				if (flag)
				{
					this.AddString(key, "null");
				}
				else
				{
					Type type = value.GetType();
					bool flag2 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
					if (flag2)
					{
						this.AddString(key, value.Cast<string>());
					}
					else
					{
						bool flag3 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
						if (flag3)
						{
							this.AddString(key, Char.ToString((char)value));
						}
						else
						{
							bool flag4 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag4)
							{
								this.AddInt32(key, (int)((sbyte)value));
							}
							else
							{
								bool flag5 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
								if (flag5)
								{
									this.AddInt32(key, (int)((byte)value));
								}
								else
								{
									bool flag6 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
									if (flag6)
									{
										this.AddInt32(key, (int)((short)value));
									}
									else
									{
										bool flag7 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
										if (flag7)
										{
											this.AddUInt32(key, (uint)((ushort)value));
										}
										else
										{
											bool flag8 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
											if (flag8)
											{
												this.AddInt32(key, (int)value);
											}
											else
											{
												bool flag9 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
												if (flag9)
												{
													this.AddUInt32(keyValuePair.Key, (uint)value);
												}
												else
												{
													bool flag10 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
													if (flag10)
													{
														this.AddInt64(key, (long)value);
													}
													else
													{
														bool flag11 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ulong>());
														if (flag11)
														{
															this.AddUInt64(key, (ulong)value);
														}
														else
														{
															bool flag12 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
															if (flag12)
															{
																this.AddBool(key, (bool)value);
															}
															else
															{
																bool flag13 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
																if (flag13)
																{
																	this.AddDouble(key, (double)Convert.ToDecimal((float)value));
																}
																else
																{
																	bool flag14 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
																	if (flag14)
																	{
																		this.AddDouble(key, (double)value);
																	}
																	else
																	{
																		bool flag15 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Decimal>());
																		if (flag15)
																		{
																			this.AddDouble(key, (double)Convert.ToDecimal((Decimal)value));
																		}
																		else
																		{
																			bool isValueType = type.IsValueType;
																			if (!isValueType)
																			{
																				throw new ArgumentException(String.Format("Invalid type: {0} passed", type));
																			}
																			this.AddString(key, value.ToString());
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04000054 RID: 84
		private static readonly CustomEventData.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<CustomEventData.Internal_CreateDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Create");

		// Token: 0x04000055 RID: 85
		private static readonly CustomEventData.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<CustomEventData.Internal_DestroyDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Destroy");

		// Token: 0x04000056 RID: 86
		private static readonly CustomEventData.AddStringDelegate AddStringDelegateField = IL2CPP.ResolveICall<CustomEventData.AddStringDelegate>("UnityEngine.Analytics.CustomEventData::AddString");

		// Token: 0x04000057 RID: 87
		private static readonly CustomEventData.AddInt32Delegate AddInt32DelegateField = IL2CPP.ResolveICall<CustomEventData.AddInt32Delegate>("UnityEngine.Analytics.CustomEventData::AddInt32");

		// Token: 0x04000058 RID: 88
		private static readonly CustomEventData.AddUInt32Delegate AddUInt32DelegateField = IL2CPP.ResolveICall<CustomEventData.AddUInt32Delegate>("UnityEngine.Analytics.CustomEventData::AddUInt32");

		// Token: 0x04000059 RID: 89
		private static readonly CustomEventData.AddInt64Delegate AddInt64DelegateField = IL2CPP.ResolveICall<CustomEventData.AddInt64Delegate>("UnityEngine.Analytics.CustomEventData::AddInt64");

		// Token: 0x0400005A RID: 90
		private static readonly CustomEventData.AddUInt64Delegate AddUInt64DelegateField = IL2CPP.ResolveICall<CustomEventData.AddUInt64Delegate>("UnityEngine.Analytics.CustomEventData::AddUInt64");

		// Token: 0x0400005B RID: 91
		private static readonly CustomEventData.AddBoolDelegate AddBoolDelegateField = IL2CPP.ResolveICall<CustomEventData.AddBoolDelegate>("UnityEngine.Analytics.CustomEventData::AddBool");

		// Token: 0x0400005C RID: 92
		private static readonly CustomEventData.AddDoubleDelegate AddDoubleDelegateField = IL2CPP.ResolveICall<CustomEventData.AddDoubleDelegate>("UnityEngine.Analytics.CustomEventData::AddDouble");

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate IntPtr Internal_CreateDelegate(IntPtr ced, IntPtr name);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate bool AddStringDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate bool AddInt32Delegate(IntPtr @this, IntPtr key, int value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate bool AddUInt32Delegate(IntPtr @this, IntPtr key, uint value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate bool AddInt64Delegate(IntPtr @this, IntPtr key, long value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate bool AddUInt64Delegate(IntPtr @this, IntPtr key, ulong value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate bool AddBoolDelegate(IntPtr @this, IntPtr key, bool value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool AddDoubleDelegate(IntPtr @this, IntPtr key, double value);
	}
}
